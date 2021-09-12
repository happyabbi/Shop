using Shop.IBll;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Bll
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        public override void SetCurrentDal()
        {
            //重载抽象类抽象方法，在对象实例化时对具体的数据操作类进行实例
            this.CurrentDal = this.CurrentDBSession.StudentDal;
        }
    }
}
