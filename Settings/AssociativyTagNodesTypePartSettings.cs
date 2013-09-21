using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.ViewModels;

namespace Lombiq.Associativy.TagNodes.Settings
{
    public class AssociativyTagNodesTypePartSettings
    {
        public int ProjectionId { get; set; }
    }

    public class AssociativyTagNodesSettingsHooks : ContentDefinitionEditorEventsBase
    {
        public override IEnumerable<TemplateViewModel> TypePartEditor(ContentTypePartDefinition definition)
        {
            if (definition.PartDefinition.Name != "AssociativyTagNodesPart")
                yield break;

            yield return DefinitionTemplate(definition.Settings.GetModel<AssociativyTagNodesTypePartSettings>());
        }

        public override IEnumerable<TemplateViewModel> TypePartEditorUpdate(ContentTypePartDefinitionBuilder builder, IUpdateModel updateModel)
        {
            if (builder.Name != "AssociativyTagNodesPart")
                yield break;

            var model = new AssociativyTagNodesTypePartSettings();
            updateModel.TryUpdateModel(model, "AssociativyTagNodesTypePartSettings", null, null);
            builder.WithSetting("AssociativyTagNodesTypePartSettings.ProjectionId", model.ProjectionId.ToString());

            yield return DefinitionTemplate(model);
        }
    }
}