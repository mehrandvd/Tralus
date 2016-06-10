using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base.General;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public abstract class AccStructure : EntityBase, IHierarchyEntity
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public abstract IHierarchyEntity Parent { get; set; }

        ITreeNode IHCategory.Parent
        {
            get { return Parent; }
            set { Parent = (IHierarchyEntity)value; }
        }
        ITreeNode ITreeNode.Parent => Parent;

        public abstract IBindingList Children { get; }

        public virtual Image GetImage(out string imageName)
        {
            imageName = "BO_Category";
            return ImageLoader.Instance.GetImageInfo(imageName).Image;
        }
    }
}
