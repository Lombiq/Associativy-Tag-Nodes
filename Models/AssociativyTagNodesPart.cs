using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Associativy.GraphDiscovery;
using Orchard.ContentManagement;
using Orchard.Core.Common.Utilities;

namespace Associativy.TagNodes.Models
{
    public class AssociativyTagNodesPart : ContentPart
    {
        private readonly LazyField<IEnumerable<KeyValuePair<IGraph, IEnumerable<IContent>>>> _connectedTagNodes = new LazyField<IEnumerable<KeyValuePair<IGraph, IEnumerable<IContent>>>>();
        internal LazyField<IEnumerable<KeyValuePair<IGraph, IEnumerable<IContent>>>> ConnectedTagNodesField { get { return _connectedTagNodes; } }
        public IEnumerable<KeyValuePair<IGraph, IEnumerable<IContent>>> ConnectedTagNodes { get { return _connectedTagNodes.Value; } }

        private readonly LazyField<IContent> _tagNodeListingProjection = new LazyField<IContent>();
        internal LazyField<IContent> TagNodeListingProjectionField { get { return _tagNodeListingProjection; } }
        public IContent TagNodeListingProjection { get { return _tagNodeListingProjection.Value; } }
    }
}