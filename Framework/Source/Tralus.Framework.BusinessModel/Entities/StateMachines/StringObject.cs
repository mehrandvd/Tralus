using System;
using DevExpress.ExpressApp.DC;

namespace Tralus.Framework.BusinessModel.Entities.StateMachines
{
    [DomainComponent]
    public class StringObject
    {
        public StringObject(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }
}