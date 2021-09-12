using Shop.IDal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DalFactory
{
    //抽象工厂+反射 为数据会话层DBSession提供创建数据操作类实例的方法
    public class AbstractFactory
    {
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["AssemblyPath"];
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];

        private static Object CreateInstance(string className)
        {
            var assmbly = Assembly.Load(AssemblyPath);
            return assmbly.CreateInstance(className);
        }
        public static IStudentDal CreateStudentDal()
        {
            string fullClassName = NameSpace + ".StudentDal";
            return CreateInstance(fullClassName) as IStudentDal;
        }
    }
}
