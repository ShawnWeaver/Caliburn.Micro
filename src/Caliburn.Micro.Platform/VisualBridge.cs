using System.Windows;

namespace Caliburn.Micro
{
	/// <summary>
	/// Hosts properties related to creating a "visual bridge" to link separate visual trees.
	/// </summary>
	public static class VisualBridge
	{
		#region Parent DependencyProperty

		/// <summary>
		/// Defines a "virtual" visual parent for the target element.
		/// </summary>
		public static readonly DependencyProperty ParentProperty =
			DependencyProperty.RegisterAttached("Parent",
												typeof(FrameworkElement),
												typeof(VisualBridge));

		/// <summary>
		/// Gets the "virtual" parent element.
		/// </summary>
		/// <param name="obj">The element to which the property is attached.</param>
		/// <returns>The "virtual" parent visual element for the target of the attached property.</returns>
		public static FrameworkElement GetParent(DependencyObject obj)
		{
			return (FrameworkElement)obj.GetValue(ParentProperty);
		}

		/// <summary>
		/// Sets the "virtual" parent element.
		/// </summary>
		/// <param name="obj">The element to which the property is attached.</param>
		/// <param name="value">The "virtual" parent visual element to use.</param>
		public static void SetParent(DependencyObject obj, FrameworkElement value)
		{
			obj.SetValue(ParentProperty, value);
		}

		/// <summary>
		/// Checks if the specified object has a "virtual" parent element set.
		/// </summary>
		/// <param name="obj">The element to which the property may be attached.</param>
		/// <returns><c>True</c> if a "virtual" parent has been set for the specified object; otherwise, <c>false</c>.</returns>
		public static bool HasParentSet(DependencyObject obj)
		{
			return GetParent(obj) != null;
		}

		#endregion Parent DependencyProperty
	}
}
