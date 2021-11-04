using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base( true,message)
        {
            // mesaj verilerek kullanılarak başarılı sonuca mesaj oluşturan yapıcı sınıf
        }
        public SuccessResult() :base(true)
        {
            // mesaj vermeden başarılı sonuç için kullanacagımız yapıcı sınıf
        }
    }
}
