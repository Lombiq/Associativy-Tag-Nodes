using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Associativy.TagNodes.Models;
using Orchard.ContentManagement.Drivers;

namespace Associativy.TagNodes.Drivers
{
    public class AssociativyTagNodesPartDriver : ContentPartDriver<AssociativyTagNodesPart>
    {
        protected override DriverResult Display(AssociativyTagNodesPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_AssociativyTagNodes",
                () => shapeHelper.Parts_AssociativyTagNodes());
        }
    }
}