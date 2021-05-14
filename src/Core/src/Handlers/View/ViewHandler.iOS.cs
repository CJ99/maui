﻿using CoreAnimation;
using CoreGraphics;
using NativeView = UIKit.UIView;

namespace Microsoft.Maui.Handlers
{
	public partial class ViewHandler
	{
		CALayer? _layer;
		CGPoint? _originalAnchor;

		partial void ConnectingHandler(NativeView? nativeView)
		{
			_layer = nativeView?.Layer;
			_originalAnchor = _layer?.AnchorPoint;
		}

		partial void DisconnectingHandler(NativeView? nativeView)
		{
			_layer = null;
			_originalAnchor = null;
		}

		static partial void UpdatingWidth(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		static partial void UpdatingHeight(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapTranslationX(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapTranslationY(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapScale(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapScaleX(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapScaleY(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapRotation(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapRotationX(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapRotationY(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapAnchorX(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		public static void MapAnchorY(IViewHandler handler, IView view)
		{
			UpdateTransformation(handler, view);
		}

		internal static void UpdateTransformation(IViewHandler handler, IView view)
		{
			((NativeView?)handler.NativeView)?.UpdateTransformation(view, ((ViewHandler)handler)._layer, ((ViewHandler)handler)._originalAnchor);
		}
	}
}