using Shop.Infrastucture.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infrastucture.Model
{
    public class SystemCommandModel : IBaseModel
    {
        SystemCommandEnum _systemCommandEnum;
        public SystemCommandEnum SystemCommand 
        {
            get
            {
                return _systemCommandEnum;
            }
        }

        public SystemCommandModel(SystemCommandEnum systemCommandEnum)
        {
            _systemCommandEnum = systemCommandEnum;
        }
    }
}
