namespace CleanArchitectureExample.Application.Common.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string[] errors) : base("Ocoreram multiplos erros")
    {
        Errors = errors; 
    }
    

    public string[] Errors { get; set; }    
    
}