using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Lombiq.Associativy.TagNodes
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("TagNode",
                    cfg => cfg
                        .WithPart("CommonPart", part => part
                            .WithSetting("DateEditorSettings.ShowDateEditor", "false")
                            .WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
                        .WithPart("AssociativyNodeManagementPart")
                        .WithPart("AssociativyNodeTitleLabelPart")
                        .WithPart("ImplicitlyCreatableAssociativyNodePart")
                        .Creatable()
                );


            return 1;
        }
    }
}