namespace Picoage.Logger
{
    public interface IPicoageLogger<T>
    {
        public void Information(string id, string message);
        
        public void Warning(string id,string message);
        
        public void Error(string id, Exception exception, string message); 
        
        public void Critical(string id, Exception exception,string message); 
               
    }
}
