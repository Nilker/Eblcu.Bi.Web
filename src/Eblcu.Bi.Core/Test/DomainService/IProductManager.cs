

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using Eblcu.Bi.Test;


namespace Eblcu.Bi.Test.DomainService
{
    public interface IProductManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitProduct();



		 
      
         

    }
}
