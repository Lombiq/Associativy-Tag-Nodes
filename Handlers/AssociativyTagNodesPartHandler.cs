using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement.Handlers;
using Lombiq.Associativy.TagNodes.Models;
using Associativy.GraphDiscovery;
using Orchard.ContentManagement;
using Associativy.Services;
using Associativy.Models;
using Lombiq.Associativy.TagNodes.Settings;

namespace Lombiq.Associativy.TagNodes.Handlers
{
    public class AssociativyTagNodesPartHandler : ContentHandler
    {
        public AssociativyTagNodesPartHandler(IGraphManager graphManager)
        {
            OnActivated<AssociativyTagNodesPart>((context, part) =>
            {
                part.ConnectedTagNodesField.Loader(() =>
                    {
                        var graphs = graphManager.FindGraphs(new GraphContext { ContentTypes = new[] { "TagNode", context.ContentType } });
                        var kvps = new List<KeyValuePair<IGraph, IEnumerable<IContent>>>();

                        foreach (var graph in graphs)
                        {
                            var items = context.ContentItem.ContentManager
                                .Query("TagNode")
                                .ForContentItems(graph.Services.ConnectionManager.GetNeighbourIds(context.ContentItem.Id))
                                .Join<AssociativyNodeLabelPartRecord>()
                                .List<IContent>();

                            kvps.Add(new KeyValuePair<IGraph, IEnumerable<IContent>>(graph, items));
                        }

                        var z = part.Settings.GetModel<AssociativyTagNodesTypePartSettings>().ProjectionId;
                        var y = context.ContentItem.ContentManager.Get(z);
                        return kvps;
                    });

                part.TagNodeListingProjectionField.Loader(() => context.ContentItem.ContentManager.Get(part.Settings.GetModel<AssociativyTagNodesTypePartSettings>().ProjectionId));
            });
        }
    }
}