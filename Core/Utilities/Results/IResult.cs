using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // temel voidler için başlangıc kodu.   
    public interface IResult
    {
        // işlemin başarılı olup olmadıgını dondurur
        bool Success { get; }
        // kullanıcıya yapılan işlem ile alakalı mesaj vericek metot.
        string Message { get; }
    }
}
