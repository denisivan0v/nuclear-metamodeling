﻿using System;
using System.Collections.Generic;
using System.Linq;

using NuClear.Metamodeling.Elements.Aspects.Features;
using NuClear.Metamodeling.Elements.Aspects.Features.Handler;
using NuClear.Metamodeling.Elements.Aspects.Features.Mode;
using NuClear.Metamodeling.Elements.Aspects.Features.Operations;
using NuClear.Metamodeling.Elements.Aspects.Features.Resources.Images;
using NuClear.Metamodeling.Elements.Aspects.Features.Resources.Titles;
using NuClear.Metamodeling.Elements.Identities;

namespace NuClear.Metamodeling.Elements.Concrete.Hierarchy
{    
    public sealed class HierarchyMetadata : MetadataElement<HierarchyMetadata, HierarchyMetadataBuilder>, 
        ITitledElement, 
        IImageBoundElement,
        IHandlerBoundElement,
        IOperationsBoundElement,
        ISharable
    {
        private IMetadataElementIdentity _identity;

        public HierarchyMetadata(Uri id, IEnumerable<IMetadataFeature> features)
            : base(features)
        {
            _identity = id.AsIdentity();
        }

        public override IMetadataElementIdentity Identity
        {
            get
            {
                return _identity;
            }
        }

        public ITitleDescriptor TitleDescriptor
        {
            get
            {
                var feature = Features.OfType<TitleFeature>().SingleOrDefault();
                return feature != null ? feature.TitleDescriptor : null;
            }
        }

        public IImageDescriptor ImageDescriptor
        {
            get
            {
                var feature = Features.OfType<ImageFeature>().SingleOrDefault();
                return feature != null ? feature.ImageDescriptor : null;
            }
        }

        public IHandlerFeature Handler
        {
            get
            {
                return Features.OfType<IHandlerFeature>().SingleOrDefault();
            }
        }

        public bool HasHandler 
        {
            get
            {
                return Features.OfType<IHandlerFeature>().SingleOrDefault() != null;
            }
        }

        public bool HasOperations 
        {
            get
            {
                var operationsSet = Features.OfType<OperationsSetFeature>().SingleOrDefault();
                return operationsSet != null && operationsSet.OperationFeatures.Any();
            }
        }

        public IEnumerable<OperationFeature> OperationFeatures 
        {
            get
            {
                var operationsSet = Features.OfType<OperationsSetFeature>().SingleOrDefault();
                return operationsSet != null ? operationsSet.OperationFeatures : Enumerable.Empty<OperationFeature>();
            }
        }

        public bool IsShared
        {
            get
            {
                return Features.OfType<SharedFeature>().SingleOrDefault() != null;
            }
        }

        public override void ActualizeId(IMetadataElementIdentity actualMetadataElementIdentity)
        {
            _identity = actualMetadataElementIdentity;
        }
    }
}
