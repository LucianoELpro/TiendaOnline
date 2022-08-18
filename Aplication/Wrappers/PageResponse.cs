using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Wrappers
{
    public class PageResponse<T> :Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PageResponse(T data,int pageNumber,int pageSize )
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            Data = data;           
            Accomplished = true;
            Message = null;
            Errors = null;

        }
        
    }
}
