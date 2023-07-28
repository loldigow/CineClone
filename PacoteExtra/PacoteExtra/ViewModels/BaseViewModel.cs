namespace PacoteExtra.ViewModels
{
    public class BaseViewModel
    {
        public virtual void EventoAoAparecer() { }
        public virtual void EventoAoDesaparecer() { }
        public virtual bool EventoNoClickBotaoVoltar()
        {
            return true;
        }
    }
}
