using Coldairarrow.Entity.ProjectManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace Coldairarrow.Business.ProjectManage
{
    public class Dev_ProjectBusiness : BaseBusiness<Dev_Project>, IDev_ProjectBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        public List<Dev_Project> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //ɸѡ
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Dev_Project GetTheData(string id)
        {
            return GetEntity(id);
        }

        public void AddData(Dev_Project newData)
        {
            Insert(newData);
        }

        public void UpdateData(Dev_Project theData)
        {
            Update(theData);
        }

        public void DeleteData(List<string> ids)
        {
            Delete(ids);
        }

        #endregion

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}