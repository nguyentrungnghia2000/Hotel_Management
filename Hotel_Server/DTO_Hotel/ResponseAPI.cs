using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class ResponseAPI<T>
    {
        public bool IsSuccess { get; set; }
        public T Result { get; set; }
        public string ErrorMessenge { get; set; }
        public string ErrorCode { get; set; }
        public ResponseAPI(bool _is)
        {
            IsSuccess = _is;
        }
        public ResponseAPI(T obj)
        {
            IsSuccess = true;
            Result = obj;
        }
        public ResponseAPI(string stringC, string  mess)
        {
            IsSuccess = false;
            ErrorCode = stringC;
            ErrorMessenge = mess;

        }
    }
}