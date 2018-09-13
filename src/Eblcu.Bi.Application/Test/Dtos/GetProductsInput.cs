
using Abp.Runtime.Validation;
using Eblcu.Bi.Dtos;
using Eblcu.Bi.Test;

namespace Eblcu.Bi.Test.Dtos
{
    public class GetProductsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
