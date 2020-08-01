using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class ResponseAPI<T>
    {
        public bool IsSuccess { get; set; }
        public T Result { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessenge { get; set; }
    }
}
