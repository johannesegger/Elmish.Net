using System.Reactive.Linq;

namespace Wpf.NoXaml.Utils
{
    public static class ContentElementExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> GotFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> LostFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheelObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheelObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> GotMouseCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> LostMouseCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursorObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> StylusDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGestureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGestureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> GotStylusCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> LostStylusCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInputObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> TextInputObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDragObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDragObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedbackObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedbackObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragOverObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragOverObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDropObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DropObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> GotTouchCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> LostTouchCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class UIElementExtensions
    {
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheelObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheelObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> GotMouseCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> LostMouseCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursorObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> StylusDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGestureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGestureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> GotStylusCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> LostStylusCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInputObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> TextInputObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDragObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDragObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragOverObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragOverObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDropObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DropObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> GotTouchCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> LostTouchCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> LayoutUpdatedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.LayoutUpdated += h,
                    h => element.LayoutUpdated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> GotFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> LostFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsHitTestVisibleChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsHitTestVisibleChanged += h,
                    h => element.IsHitTestVisibleChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsVisibleChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsVisibleChanged += h,
                    h => element.IsVisibleChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationStartingEventArgs> ManipulationStartingObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationStartingEventArgs>(
                    h => element.ManipulationStarting += h,
                    h => element.ManipulationStarting -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationStartedEventArgs> ManipulationStartedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationStartedEventArgs>(
                    h => element.ManipulationStarted += h,
                    h => element.ManipulationStarted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDeltaObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationDeltaEventArgs>(
                    h => element.ManipulationDelta += h,
                    h => element.ManipulationDelta -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStartingObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationInertiaStartingEventArgs>(
                    h => element.ManipulationInertiaStarting += h,
                    h => element.ManipulationInertiaStarting -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>(
                    h => element.ManipulationBoundaryFeedback += h,
                    h => element.ManipulationBoundaryFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompletedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationCompletedEventArgs>(
                    h => element.ManipulationCompleted += h,
                    h => element.ManipulationCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class UIElement3DExtensions
    {
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheelObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheelObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> MouseLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> GotMouseCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseEventArgs> LostMouseCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursorObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusDownEventArgs> StylusDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusInRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGestureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGestureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> GotStylusCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusEventArgs> LostStylusCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyEventArgs> KeyUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInputObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TextCompositionEventArgs> TextInputObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDragObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDragObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedbackObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedbackObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragOverObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragOverObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDragLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DragLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> PreviewDropObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DragEventArgs> DropObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> GotTouchCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> LostTouchCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.TouchEventArgs> TouchLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> GotFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> LostFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsHitTestVisibleChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsHitTestVisibleChanged += h,
                    h => element.IsHitTestVisibleChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsVisibleChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsVisibleChanged += h,
                    h => element.IsVisibleChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class D3DImageExtensions
    {
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsFrontBufferAvailableChangedObservable(this System.Windows.Interop.D3DImage element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsFrontBufferAvailableChanged += h,
                    h => element.IsFrontBufferAvailableChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class MediaPlayerExtensions
    {
        public static System.IObservable<System.Windows.Media.ExceptionEventArgs> MediaFailedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.MediaFailed += h,
                    h => element.MediaFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> MediaOpenedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.MediaOpened += h,
                    h => element.MediaOpened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> MediaEndedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.MediaEnded += h,
                    h => element.MediaEnded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> BufferingStartedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.BufferingStarted += h,
                    h => element.BufferingStarted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> BufferingEndedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.BufferingEnded += h,
                    h => element.BufferingEnded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Media.MediaScriptCommandEventArgs> ScriptCommandObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.MediaScriptCommandEventArgs>(
                    h => element.ScriptCommand += h,
                    h => element.ScriptCommand -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class TimelineExtensions
    {
        public static System.IObservable<System.EventArgs> CurrentStateInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentStateInvalidated += h,
                    h => element.CurrentStateInvalidated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> CurrentTimeInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentTimeInvalidated += h,
                    h => element.CurrentTimeInvalidated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> CurrentGlobalSpeedInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentGlobalSpeedInvalidated += h,
                    h => element.CurrentGlobalSpeedInvalidated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> CompletedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Completed += h,
                    h => element.Completed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> RemoveRequestedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.RemoveRequested += h,
                    h => element.RemoveRequested -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class BitmapSourceExtensions
    {
        public static System.IObservable<System.EventArgs> DownloadCompletedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DownloadCompleted += h,
                    h => element.DownloadCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Media.Imaging.DownloadProgressEventArgs> DownloadProgressObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.Imaging.DownloadProgressEventArgs>(
                    h => element.DownloadProgress += h,
                    h => element.DownloadProgress -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Media.ExceptionEventArgs> DownloadFailedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.DownloadFailed += h,
                    h => element.DownloadFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Media.ExceptionEventArgs> DecodeFailedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.DecodeFailed += h,
                    h => element.DecodeFailed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class PixelShaderExtensions
    {
        public static System.IObservable<System.EventArgs> InvalidPixelShaderEncounteredObservable()
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => System.Windows.Media.Effects.PixelShader.InvalidPixelShaderEncountered += h,
                    h => System.Windows.Media.Effects.PixelShader.InvalidPixelShaderEncountered -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class FrameworkContentElementExtensions
    {
        public static System.IObservable<System.Windows.Data.DataTransferEventArgs> TargetUpdatedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.TargetUpdated += h,
                    h => element.TargetUpdated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Data.DataTransferEventArgs> SourceUpdatedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.SourceUpdated += h,
                    h => element.SourceUpdated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> DataContextChangedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.DataContextChanged += h,
                    h => element.DataContextChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> InitializedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Initialized += h,
                    h => element.Initialized -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> LoadedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Loaded += h,
                    h => element.Loaded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnloadedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unloaded += h,
                    h => element.Unloaded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipOpeningObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipOpening += h,
                    h => element.ToolTipOpening -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipClosingObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipClosing += h,
                    h => element.ToolTipClosing -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuOpeningObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuOpening += h,
                    h => element.ContextMenuOpening -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuClosingObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuClosing += h,
                    h => element.ContextMenuClosing -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class FrameworkElementExtensions
    {
        public static System.IObservable<System.Windows.Data.DataTransferEventArgs> TargetUpdatedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.TargetUpdated += h,
                    h => element.TargetUpdated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Data.DataTransferEventArgs> SourceUpdatedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.SourceUpdated += h,
                    h => element.SourceUpdated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DependencyPropertyChangedEventArgs> DataContextChangedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.DataContextChanged += h,
                    h => element.DataContextChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RequestBringIntoViewEventArgs> RequestBringIntoViewObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs>(
                    h => element.RequestBringIntoView += h,
                    h => element.RequestBringIntoView -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.SizeChangedEventArgs> SizeChangedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs>(
                    h => element.SizeChanged += h,
                    h => element.SizeChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> InitializedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Initialized += h,
                    h => element.Initialized -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> LoadedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Loaded += h,
                    h => element.Loaded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnloadedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unloaded += h,
                    h => element.Unloaded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipOpeningObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipOpening += h,
                    h => element.ToolTipOpening -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipClosingObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipClosing += h,
                    h => element.ToolTipClosing -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuOpeningObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuOpening += h,
                    h => element.ContextMenuOpening -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuClosingObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuClosing += h,
                    h => element.ContextMenuClosing -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class VisualStateGroupExtensions
    {
        public static System.IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChangedObservable(this System.Windows.VisualStateGroup element)
        {
            return Observable
                .FromEventPattern<System.Windows.VisualStateChangedEventArgs>(
                    h => element.CurrentStateChanged += h,
                    h => element.CurrentStateChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChangingObservable(this System.Windows.VisualStateGroup element)
        {
            return Observable
                .FromEventPattern<System.Windows.VisualStateChangedEventArgs>(
                    h => element.CurrentStateChanging += h,
                    h => element.CurrentStateChanging -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class WindowExtensions
    {
        public static System.IObservable<System.EventArgs> SourceInitializedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SourceInitialized += h,
                    h => element.SourceInitialized -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DpiChangedEventArgs> DpiChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> ActivatedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Activated += h,
                    h => element.Activated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> DeactivatedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Deactivated += h,
                    h => element.Deactivated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> StateChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.StateChanged += h,
                    h => element.StateChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> LocationChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.LocationChanged += h,
                    h => element.LocationChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.ComponentModel.CancelEventArgs> ClosingObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                    h => element.Closing += h,
                    h => element.Closing -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> ClosedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> ContentRenderedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.ContentRendered += h,
                    h => element.ContentRendered -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ThumbButtonInfoExtensions
    {
        public static System.IObservable<System.EventArgs> ClickObservable(this System.Windows.Shell.ThumbButtonInfo element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class CollectionViewSourceExtensions
    {
        public static System.IObservable<System.Windows.Data.FilterEventArgs> FilterObservable(this System.Windows.Data.CollectionViewSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.FilterEventHandler, System.Windows.Data.FilterEventArgs>(
                    h => element.Filter += h,
                    h => element.Filter -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class NavigationWindowExtensions
    {
        public static System.IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> NavigatingObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgressObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(
                    h => element.NavigationProgress += h,
                    h => element.NavigationProgress -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(
                    h => element.NavigationFailed += h,
                    h => element.NavigationFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> NavigatedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompletedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStoppedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.NavigationStopped += h,
                    h => element.NavigationStopped -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigationObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(
                    h => element.FragmentNavigation += h,
                    h => element.FragmentNavigation -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class PageFunctionExtensions
    {
        public static System.IObservable<System.Windows.Navigation.ReturnEventArgs<T>> ReturnObservable<T>(this System.Windows.Navigation.PageFunction<T> element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.ReturnEventHandler<T>, System.Windows.Navigation.ReturnEventArgs<T>>(
                    h => element.Return += h,
                    h => element.Return -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class HyperlinkExtensions
    {
        public static System.IObservable<System.Windows.Navigation.RequestNavigateEventArgs> RequestNavigateObservable(this System.Windows.Documents.Hyperlink element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.RequestNavigateEventHandler, System.Windows.Navigation.RequestNavigateEventArgs>(
                    h => element.RequestNavigate += h,
                    h => element.RequestNavigate -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> ClickObservable(this System.Windows.Documents.Hyperlink element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class PageContentExtensions
    {
        public static System.IObservable<System.Windows.Documents.GetPageRootCompletedEventArgs> GetPageRootCompletedObservable(this System.Windows.Documents.PageContent element)
        {
            return Observable
                .FromEventPattern<System.Windows.Documents.GetPageRootCompletedEventHandler, System.Windows.Documents.GetPageRootCompletedEventArgs>(
                    h => element.GetPageRootCompleted += h,
                    h => element.GetPageRootCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class CalendarExtensions
    {
        public static System.IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectedDatesChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectedDatesChanged += h,
                    h => element.SelectedDatesChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.CalendarDateChangedEventArgs> DisplayDateChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.CalendarDateChangedEventArgs>(
                    h => element.DisplayDateChanged += h,
                    h => element.DisplayDateChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.CalendarModeChangedEventArgs> DisplayModeChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.CalendarModeChangedEventArgs>(
                    h => element.DisplayModeChanged += h,
                    h => element.DisplayModeChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> SelectionModeChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.EventArgs>(
                    h => element.SelectionModeChanged += h,
                    h => element.SelectionModeChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ComboBoxExtensions
    {
        public static System.IObservable<System.EventArgs> DropDownOpenedObservable(this System.Windows.Controls.ComboBox element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DropDownOpened += h,
                    h => element.DropDownOpened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> DropDownClosedObservable(this System.Windows.Controls.ComboBox element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DropDownClosed += h,
                    h => element.DropDownClosed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ContextMenuExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> OpenedObservable(this System.Windows.Controls.ContextMenu element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> ClosedObservable(this System.Windows.Controls.ContextMenu element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ControlExtensions
    {
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDoubleClickObservable(this System.Windows.Controls.Control element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDoubleClick += h,
                    h => element.PreviewMouseDoubleClick -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDoubleClickObservable(this System.Windows.Controls.Control element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDoubleClick += h,
                    h => element.MouseDoubleClick -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DataGridExtensions
    {
        public static System.IObservable<System.Windows.Controls.DataGridColumnEventArgs> ColumnDisplayIndexChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnEventArgs>(
                    h => element.ColumnDisplayIndexChanged += h,
                    h => element.ColumnDisplayIndexChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowEventArgs> LoadingRowObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEventArgs>(
                    h => element.LoadingRow += h,
                    h => element.LoadingRow -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowEventArgs> UnloadingRowObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEventArgs>(
                    h => element.UnloadingRow += h,
                    h => element.UnloadingRow -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowEditEndingEventArgs> RowEditEndingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEditEndingEventArgs>(
                    h => element.RowEditEnding += h,
                    h => element.RowEditEnding -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridCellEditEndingEventArgs> CellEditEndingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellEditEndingEventArgs>(
                    h => element.CellEditEnding += h,
                    h => element.CellEditEnding -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> CurrentCellChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.EventArgs>(
                    h => element.CurrentCellChanged += h,
                    h => element.CurrentCellChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridBeginningEditEventArgs> BeginningEditObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridBeginningEditEventArgs>(
                    h => element.BeginningEdit += h,
                    h => element.BeginningEdit -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> PreparingCellForEditObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(
                    h => element.PreparingCellForEdit += h,
                    h => element.PreparingCellForEdit -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.AddingNewItemEventArgs> AddingNewItemObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.AddingNewItemEventArgs>(
                    h => element.AddingNewItem += h,
                    h => element.AddingNewItem -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InitializingNewItemEventArgs> InitializingNewItemObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InitializingNewItemEventHandler, System.Windows.Controls.InitializingNewItemEventArgs>(
                    h => element.InitializingNewItem += h,
                    h => element.InitializingNewItem -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> LoadingRowDetailsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.LoadingRowDetails += h,
                    h => element.LoadingRowDetails -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> UnloadingRowDetailsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.UnloadingRowDetails += h,
                    h => element.UnloadingRowDetails -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> RowDetailsVisibilityChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.RowDetailsVisibilityChanged += h,
                    h => element.RowDetailsVisibilityChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.SelectedCellsChangedEventArgs> SelectedCellsChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectedCellsChangedEventHandler, System.Windows.Controls.SelectedCellsChangedEventArgs>(
                    h => element.SelectedCellsChanged += h,
                    h => element.SelectedCellsChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridSortingEventArgs> SortingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridSortingEventHandler, System.Windows.Controls.DataGridSortingEventArgs>(
                    h => element.Sorting += h,
                    h => element.Sorting -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> AutoGeneratedColumnsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.AutoGeneratedColumns += h,
                    h => element.AutoGeneratedColumns -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumnObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(
                    h => element.AutoGeneratingColumn += h,
                    h => element.AutoGeneratingColumn -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridColumnReorderingEventArgs> ColumnReorderingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnReorderingEventArgs>(
                    h => element.ColumnReordering += h,
                    h => element.ColumnReordering -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> ColumnHeaderDragStartedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventArgs>(
                    h => element.ColumnHeaderDragStarted += h,
                    h => element.ColumnHeaderDragStarted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> ColumnHeaderDragDeltaObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventArgs>(
                    h => element.ColumnHeaderDragDelta += h,
                    h => element.ColumnHeaderDragDelta -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> ColumnHeaderDragCompletedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventArgs>(
                    h => element.ColumnHeaderDragCompleted += h,
                    h => element.ColumnHeaderDragCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridColumnEventArgs> ColumnReorderedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnEventArgs>(
                    h => element.ColumnReordered += h,
                    h => element.ColumnReordered -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridRowClipboardEventArgs> CopyingRowClipboardContentObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowClipboardEventArgs>(
                    h => element.CopyingRowClipboardContent += h,
                    h => element.CopyingRowClipboardContent -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DataGridCellExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> SelectedObservable(this System.Windows.Controls.DataGridCell element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnselectedObservable(this System.Windows.Controls.DataGridCell element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DataGridColumnExtensions
    {
        public static System.IObservable<System.Windows.Controls.DataGridCellClipboardEventArgs> CopyingCellClipboardContentObservable(this System.Windows.Controls.DataGridColumn element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>(
                    h => element.CopyingCellClipboardContent += h,
                    h => element.CopyingCellClipboardContent -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DataGridCellClipboardEventArgs> PastingCellClipboardContentObservable(this System.Windows.Controls.DataGridColumn element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>(
                    h => element.PastingCellClipboardContent += h,
                    h => element.PastingCellClipboardContent -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DataGridRowExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> SelectedObservable(this System.Windows.Controls.DataGridRow element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnselectedObservable(this System.Windows.Controls.DataGridRow element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DatePickerExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> CalendarClosedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.CalendarClosed += h,
                    h => element.CalendarClosed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> CalendarOpenedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.CalendarOpened += h,
                    h => element.CalendarOpened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> DateValidationErrorObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>(
                    h => element.DateValidationError += h,
                    h => element.DateValidationError -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectedDateChangedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectedDateChanged += h,
                    h => element.SelectedDateChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ExpanderExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> ExpandedObservable(this System.Windows.Controls.Expander element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Expanded += h,
                    h => element.Expanded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> CollapsedObservable(this System.Windows.Controls.Expander element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Collapsed += h,
                    h => element.Collapsed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class FrameExtensions
    {
        public static System.IObservable<System.EventArgs> ContentRenderedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.ContentRendered += h,
                    h => element.ContentRendered -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> NavigatingObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgressObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(
                    h => element.NavigationProgress += h,
                    h => element.NavigationProgress -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(
                    h => element.NavigationFailed += h,
                    h => element.NavigationFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> NavigatedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompletedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStoppedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.NavigationStopped += h,
                    h => element.NavigationStopped -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigationObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(
                    h => element.FragmentNavigation += h,
                    h => element.FragmentNavigation -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ImageExtensions
    {
        public static System.IObservable<System.Windows.ExceptionRoutedEventArgs> ImageFailedObservable(this System.Windows.Controls.Image element)
        {
            return Observable
                .FromEventPattern<System.Windows.ExceptionRoutedEventArgs>(
                    h => element.ImageFailed += h,
                    h => element.ImageFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.DpiChangedEventArgs> DpiChangedObservable(this System.Windows.Controls.Image element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class InkCanvasExtensions
    {
        public static System.IObservable<System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> StrokeCollectedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs>(
                    h => element.StrokeCollected += h,
                    h => element.StrokeCollected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasGestureEventArgs> GestureObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs>(
                    h => element.Gesture += h,
                    h => element.Gesture -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasStrokesReplacedEventArgs> StrokesReplacedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokesReplacedEventHandler, System.Windows.Controls.InkCanvasStrokesReplacedEventArgs>(
                    h => element.StrokesReplaced += h,
                    h => element.StrokesReplaced -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Ink.DrawingAttributesReplacedEventArgs> DefaultDrawingAttributesReplacedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs>(
                    h => element.DefaultDrawingAttributesReplaced += h,
                    h => element.DefaultDrawingAttributesReplaced -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> ActiveEditingModeChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.ActiveEditingModeChanged += h,
                    h => element.ActiveEditingModeChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> EditingModeChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.EditingModeChanged += h,
                    h => element.EditingModeChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> EditingModeInvertedChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.EditingModeInvertedChanged += h,
                    h => element.EditingModeInvertedChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasSelectionEditingEventArgs> SelectionMovingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(
                    h => element.SelectionMoving += h,
                    h => element.SelectionMoving -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> SelectionMovedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionMoved += h,
                    h => element.SelectionMoved -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasStrokeErasingEventArgs> StrokeErasingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokeErasingEventHandler, System.Windows.Controls.InkCanvasStrokeErasingEventArgs>(
                    h => element.StrokeErasing += h,
                    h => element.StrokeErasing -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> StrokeErasedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.StrokeErased += h,
                    h => element.StrokeErased -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasSelectionEditingEventArgs> SelectionResizingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(
                    h => element.SelectionResizing += h,
                    h => element.SelectionResizing -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> SelectionResizedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionResized += h,
                    h => element.SelectionResized -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.InkCanvasSelectionChangingEventArgs> SelectionChangingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionChangingEventHandler, System.Windows.Controls.InkCanvasSelectionChangingEventArgs>(
                    h => element.SelectionChanging += h,
                    h => element.SelectionChanging -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> SelectionChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ListBoxItemExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> SelectedObservable(this System.Windows.Controls.ListBoxItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnselectedObservable(this System.Windows.Controls.ListBoxItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class MediaElementExtensions
    {
        public static System.IObservable<System.Windows.ExceptionRoutedEventArgs> MediaFailedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.ExceptionRoutedEventArgs>(
                    h => element.MediaFailed += h,
                    h => element.MediaFailed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> MediaOpenedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.MediaOpened += h,
                    h => element.MediaOpened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> BufferingStartedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.BufferingStarted += h,
                    h => element.BufferingStarted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> BufferingEndedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.BufferingEnded += h,
                    h => element.BufferingEnded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.MediaScriptCommandRoutedEventArgs> ScriptCommandObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.MediaScriptCommandRoutedEventArgs>(
                    h => element.ScriptCommand += h,
                    h => element.ScriptCommand -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> MediaEndedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.MediaEnded += h,
                    h => element.MediaEnded -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class MenuItemExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> ClickObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> CheckedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Checked += h,
                    h => element.Checked -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UncheckedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unchecked += h,
                    h => element.Unchecked -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> SubmenuOpenedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SubmenuOpened += h,
                    h => element.SubmenuOpened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> SubmenuClosedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SubmenuClosed += h,
                    h => element.SubmenuClosed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class PasswordBoxExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> PasswordChangedObservable(this System.Windows.Controls.PasswordBox element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.PasswordChanged += h,
                    h => element.PasswordChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ScrollViewerExtensions
    {
        public static System.IObservable<System.Windows.Controls.ScrollChangedEventArgs> ScrollChangedObservable(this System.Windows.Controls.ScrollViewer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs>(
                    h => element.ScrollChanged += h,
                    h => element.ScrollChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ToolTipExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> OpenedObservable(this System.Windows.Controls.ToolTip element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> ClosedObservable(this System.Windows.Controls.ToolTip element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class TreeViewExtensions
    {
        public static System.IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Object>> SelectedItemChangedObservable(this System.Windows.Controls.TreeView element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>>(
                    h => element.SelectedItemChanged += h,
                    h => element.SelectedItemChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class TreeViewItemExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> ExpandedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Expanded += h,
                    h => element.Expanded -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> CollapsedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Collapsed += h,
                    h => element.Collapsed -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> SelectedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UnselectedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class WebBrowserExtensions
    {
        public static System.IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> NavigatingObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> NavigatedObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompletedObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ButtonBaseExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> ClickObservable(this System.Windows.Controls.Primitives.ButtonBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DocumentPageViewExtensions
    {
        public static System.IObservable<System.EventArgs> PageConnectedObservable(this System.Windows.Controls.Primitives.DocumentPageView element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageConnected += h,
                    h => element.PageConnected -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> PageDisconnectedObservable(this System.Windows.Controls.Primitives.DocumentPageView element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageDisconnected += h,
                    h => element.PageDisconnected -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class DocumentViewerBaseExtensions
    {
        public static System.IObservable<System.EventArgs> PageViewsChangedObservable(this System.Windows.Controls.Primitives.DocumentViewerBase element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageViewsChanged += h,
                    h => element.PageViewsChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class PopupExtensions
    {
        public static System.IObservable<System.EventArgs> OpenedObservable(this System.Windows.Controls.Primitives.Popup element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.EventArgs> ClosedObservable(this System.Windows.Controls.Primitives.Popup element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class RangeBaseExtensions
    {
        public static System.IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> ValueChangedObservable(this System.Windows.Controls.Primitives.RangeBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(
                    h => element.ValueChanged += h,
                    h => element.ValueChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ScrollBarExtensions
    {
        public static System.IObservable<System.Windows.Controls.Primitives.ScrollEventArgs> ScrollObservable(this System.Windows.Controls.Primitives.ScrollBar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs>(
                    h => element.Scroll += h,
                    h => element.Scroll -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class SelectorExtensions
    {
        public static System.IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChangedObservable(this System.Windows.Controls.Primitives.Selector element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class TextBoxBaseExtensions
    {
        public static System.IObservable<System.Windows.Controls.TextChangedEventArgs> TextChangedObservable(this System.Windows.Controls.Primitives.TextBoxBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs>(
                    h => element.TextChanged += h,
                    h => element.TextChanged -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> SelectionChangedObservable(this System.Windows.Controls.Primitives.TextBoxBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ThumbExtensions
    {
        public static System.IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> DragStartedObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs>(
                    h => element.DragStarted += h,
                    h => element.DragStarted -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> DragDeltaObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs>(
                    h => element.DragDelta += h,
                    h => element.DragDelta -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> DragCompletedObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs>(
                    h => element.DragCompleted += h,
                    h => element.DragCompleted -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class ToggleButtonExtensions
    {
        public static System.IObservable<System.Windows.RoutedEventArgs> CheckedObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Checked += h,
                    h => element.Checked -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> UncheckedObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unchecked += h,
                    h => element.Unchecked -= h
                )
                .Select(p => p.EventArgs);
        }
        public static System.IObservable<System.Windows.RoutedEventArgs> IndeterminateObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Indeterminate += h,
                    h => element.Indeterminate -= h
                )
                .Select(p => p.EventArgs);
        }
    }
    public static class HwndHostExtensions
    {
        public static System.IObservable<System.Windows.DpiChangedEventArgs> DpiChangedObservable(this System.Windows.Interop.HwndHost element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                )
                .Select(p => p.EventArgs);
        }
    }
}
