using System;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void EncargadoTiempo();
    public sealed class Temporizador
    {
        
        private Task hilo;
        private int intervalo;
        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        public event EncargadoTiempo EventoTiempo;

        public bool Activo
        {
            get
            {
                return hilo is not null &&
                    (hilo.Status == TaskStatus.Running ||
                    hilo.Status == TaskStatus.WaitingToRun ||
                    hilo.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.Activo)
                {
                    this.cancellationTokenSource = new CancellationTokenSource();
                    this.cancellationToken = this.cancellationTokenSource.Token;
                    this.hilo = new Task(this.CorrerTiempo, this.cancellationToken);
                    this.hilo.Start();
                }
                else
                {
                    this.cancellationTokenSource.Cancel();
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void CorrerTiempo()
        {
            do
            {
                if (this.EventoTiempo is not null)
                {
                    this.EventoTiempo.Invoke();
                }
                Thread.Sleep(this.intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }
    }


}

