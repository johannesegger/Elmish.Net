using System.Reactive.Linq;

namespace Wpf.Elmish.Net
{
    public static class ContentElementExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> GotFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> LostFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsEnabledChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> FocusableChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> PreviewMouseMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> PreviewMouseWheelObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> MouseWheelObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> GotMouseCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> LostMouseCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.QueryCursorEventArgs>> QueryCursorObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> PreviewStylusDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> StylusDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInAirMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInAirMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusOutOfRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusOutOfRangeObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> PreviewStylusSystemGestureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> StylusSystemGestureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> GotStylusCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> LostStylusCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewGotKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> GotKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewLostKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> LostKeyboardFocusObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> PreviewTextInputObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> TextInputObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> PreviewQueryContinueDragObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> QueryContinueDragObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> PreviewGiveFeedbackObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> GiveFeedbackObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragOverObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragOverObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDropObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DropObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchDownObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchMoveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchUpObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> GotTouchCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> LostTouchCaptureObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchEnterObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchLeaveObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseDirectlyOverChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCapturedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCaptureWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusDirectlyOverChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCapturedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCaptureWithinChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusedChangedObservable(this System.Windows.ContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                );
        }
    }
    public static class UIElementExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> PreviewMouseMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> PreviewMouseWheelObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> MouseWheelObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> GotMouseCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> LostMouseCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.QueryCursorEventArgs>> QueryCursorObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> PreviewStylusDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> StylusDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInAirMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInAirMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusOutOfRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusOutOfRangeObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> PreviewStylusSystemGestureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> StylusSystemGestureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> GotStylusCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> LostStylusCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewGotKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> GotKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewLostKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> LostKeyboardFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> PreviewTextInputObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> TextInputObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> PreviewQueryContinueDragObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> QueryContinueDragObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> PreviewGiveFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> GiveFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragOverObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragOverObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDropObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DropObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchDownObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchMoveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchUpObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> GotTouchCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> LostTouchCaptureObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchEnterObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchLeaveObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseDirectlyOverChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCapturedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCaptureWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusDirectlyOverChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCapturedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCaptureWithinChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusedChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> LayoutUpdatedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.LayoutUpdated += h,
                    h => element.LayoutUpdated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> GotFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> LostFocusObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsEnabledChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsHitTestVisibleChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsHitTestVisibleChanged += h,
                    h => element.IsHitTestVisibleChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsVisibleChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsVisibleChanged += h,
                    h => element.IsVisibleChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> FocusableChangedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationStartingEventArgs>> ManipulationStartingObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationStartingEventArgs>(
                    h => element.ManipulationStarting += h,
                    h => element.ManipulationStarting -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationStartedEventArgs>> ManipulationStartedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationStartedEventArgs>(
                    h => element.ManipulationStarted += h,
                    h => element.ManipulationStarted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationDeltaEventArgs>> ManipulationDeltaObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationDeltaEventArgs>(
                    h => element.ManipulationDelta += h,
                    h => element.ManipulationDelta -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationInertiaStartingEventArgs>> ManipulationInertiaStartingObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationInertiaStartingEventArgs>(
                    h => element.ManipulationInertiaStarting += h,
                    h => element.ManipulationInertiaStarting -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>> ManipulationBoundaryFeedbackObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>(
                    h => element.ManipulationBoundaryFeedback += h,
                    h => element.ManipulationBoundaryFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.ManipulationCompletedEventArgs>> ManipulationCompletedObservable(this System.Windows.UIElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.ManipulationCompletedEventArgs>(
                    h => element.ManipulationCompleted += h,
                    h => element.ManipulationCompleted -= h
                );
        }
    }
    public static class UIElement3DExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDown += h,
                    h => element.PreviewMouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDown += h,
                    h => element.MouseDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseUp += h,
                    h => element.PreviewMouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseUp += h,
                    h => element.MouseUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonDown += h,
                    h => element.PreviewMouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonDown += h,
                    h => element.MouseLeftButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseLeftButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseLeftButtonUp += h,
                    h => element.PreviewMouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseLeftButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseLeftButtonUp += h,
                    h => element.MouseLeftButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonDown += h,
                    h => element.PreviewMouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonDown += h,
                    h => element.MouseRightButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseRightButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseRightButtonUp += h,
                    h => element.PreviewMouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseRightButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseRightButtonUp += h,
                    h => element.MouseRightButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> PreviewMouseMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.PreviewMouseMove += h,
                    h => element.PreviewMouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseMove += h,
                    h => element.MouseMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> PreviewMouseWheelObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.PreviewMouseWheel += h,
                    h => element.PreviewMouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseWheelEventArgs>> MouseWheelObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(
                    h => element.MouseWheel += h,
                    h => element.MouseWheel -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseEnter += h,
                    h => element.MouseEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> MouseLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.MouseLeave += h,
                    h => element.MouseLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> GotMouseCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.GotMouseCapture += h,
                    h => element.GotMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseEventArgs>> LostMouseCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(
                    h => element.LostMouseCapture += h,
                    h => element.LostMouseCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.QueryCursorEventArgs>> QueryCursorObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(
                    h => element.QueryCursor += h,
                    h => element.QueryCursor -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> PreviewStylusDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.PreviewStylusDown += h,
                    h => element.PreviewStylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusDownEventArgs>> StylusDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(
                    h => element.StylusDown += h,
                    h => element.StylusDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusUp += h,
                    h => element.PreviewStylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusUp += h,
                    h => element.StylusUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusMove += h,
                    h => element.PreviewStylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusMove += h,
                    h => element.StylusMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInAirMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInAirMove += h,
                    h => element.PreviewStylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInAirMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInAirMove += h,
                    h => element.StylusInAirMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusEnter += h,
                    h => element.StylusEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusLeave += h,
                    h => element.StylusLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusInRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusInRange += h,
                    h => element.PreviewStylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusInRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusInRange += h,
                    h => element.StylusInRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> PreviewStylusOutOfRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.PreviewStylusOutOfRange += h,
                    h => element.PreviewStylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> StylusOutOfRangeObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.StylusOutOfRange += h,
                    h => element.StylusOutOfRange -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> PreviewStylusSystemGestureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.PreviewStylusSystemGesture += h,
                    h => element.PreviewStylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusSystemGestureEventArgs>> StylusSystemGestureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(
                    h => element.StylusSystemGesture += h,
                    h => element.StylusSystemGesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> GotStylusCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.GotStylusCapture += h,
                    h => element.GotStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusEventArgs>> LostStylusCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(
                    h => element.LostStylusCapture += h,
                    h => element.LostStylusCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonDown += h,
                    h => element.StylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> StylusButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.StylusButtonUp += h,
                    h => element.StylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonDown += h,
                    h => element.PreviewStylusButtonDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.StylusButtonEventArgs>> PreviewStylusButtonUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(
                    h => element.PreviewStylusButtonUp += h,
                    h => element.PreviewStylusButtonUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyDown += h,
                    h => element.PreviewKeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyDown += h,
                    h => element.KeyDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> PreviewKeyUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.PreviewKeyUp += h,
                    h => element.PreviewKeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyEventArgs>> KeyUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(
                    h => element.KeyUp += h,
                    h => element.KeyUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewGotKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewGotKeyboardFocus += h,
                    h => element.PreviewGotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> GotKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.GotKeyboardFocus += h,
                    h => element.GotKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> PreviewLostKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.PreviewLostKeyboardFocus += h,
                    h => element.PreviewLostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.KeyboardFocusChangedEventArgs>> LostKeyboardFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(
                    h => element.LostKeyboardFocus += h,
                    h => element.LostKeyboardFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> PreviewTextInputObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.PreviewTextInput += h,
                    h => element.PreviewTextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TextCompositionEventArgs>> TextInputObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(
                    h => element.TextInput += h,
                    h => element.TextInput -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> PreviewQueryContinueDragObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.PreviewQueryContinueDrag += h,
                    h => element.PreviewQueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.QueryContinueDragEventArgs>> QueryContinueDragObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(
                    h => element.QueryContinueDrag += h,
                    h => element.QueryContinueDrag -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> PreviewGiveFeedbackObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.PreviewGiveFeedback += h,
                    h => element.PreviewGiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.GiveFeedbackEventArgs>> GiveFeedbackObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(
                    h => element.GiveFeedback += h,
                    h => element.GiveFeedback -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragEnter += h,
                    h => element.PreviewDragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragEnter += h,
                    h => element.DragEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragOverObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragOver += h,
                    h => element.PreviewDragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragOverObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragOver += h,
                    h => element.DragOver -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDragLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDragLeave += h,
                    h => element.PreviewDragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DragLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.DragLeave += h,
                    h => element.DragLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> PreviewDropObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.PreviewDrop += h,
                    h => element.PreviewDrop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DragEventArgs>> DropObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(
                    h => element.Drop += h,
                    h => element.Drop -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchDown += h,
                    h => element.PreviewTouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchDownObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchDown += h,
                    h => element.TouchDown -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchMove += h,
                    h => element.PreviewTouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchMoveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchMove += h,
                    h => element.TouchMove -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> PreviewTouchUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.PreviewTouchUp += h,
                    h => element.PreviewTouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchUpObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchUp += h,
                    h => element.TouchUp -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> GotTouchCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.GotTouchCapture += h,
                    h => element.GotTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> LostTouchCaptureObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.LostTouchCapture += h,
                    h => element.LostTouchCapture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchEnterObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchEnter += h,
                    h => element.TouchEnter -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.TouchEventArgs>> TouchLeaveObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.TouchEventArgs>(
                    h => element.TouchLeave += h,
                    h => element.TouchLeave -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseDirectlyOverChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseDirectlyOverChanged += h,
                    h => element.IsMouseDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusWithinChanged += h,
                    h => element.IsKeyboardFocusWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCapturedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCapturedChanged += h,
                    h => element.IsMouseCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsMouseCaptureWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsMouseCaptureWithinChanged += h,
                    h => element.IsMouseCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusDirectlyOverChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusDirectlyOverChanged += h,
                    h => element.IsStylusDirectlyOverChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCapturedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCapturedChanged += h,
                    h => element.IsStylusCapturedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsStylusCaptureWithinChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsStylusCaptureWithinChanged += h,
                    h => element.IsStylusCaptureWithinChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsKeyboardFocusedChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsKeyboardFocusedChanged += h,
                    h => element.IsKeyboardFocusedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> GotFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.GotFocus += h,
                    h => element.GotFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> LostFocusObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.LostFocus += h,
                    h => element.LostFocus -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsEnabledChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsEnabledChanged += h,
                    h => element.IsEnabledChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsHitTestVisibleChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsHitTestVisibleChanged += h,
                    h => element.IsHitTestVisibleChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsVisibleChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsVisibleChanged += h,
                    h => element.IsVisibleChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> FocusableChangedObservable(this System.Windows.UIElement3D element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.FocusableChanged += h,
                    h => element.FocusableChanged -= h
                );
        }
    }
    public static class D3DImageExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> IsFrontBufferAvailableChangedObservable(this System.Windows.Interop.D3DImage element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.IsFrontBufferAvailableChanged += h,
                    h => element.IsFrontBufferAvailableChanged -= h
                );
        }
    }
    public static class MediaPlayerExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Media.ExceptionEventArgs>> MediaFailedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.MediaFailed += h,
                    h => element.MediaFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> MediaOpenedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.MediaOpened += h,
                    h => element.MediaOpened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> MediaEndedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.MediaEnded += h,
                    h => element.MediaEnded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> BufferingStartedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.BufferingStarted += h,
                    h => element.BufferingStarted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> BufferingEndedObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.BufferingEnded += h,
                    h => element.BufferingEnded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Media.MediaScriptCommandEventArgs>> ScriptCommandObservable(this System.Windows.Media.MediaPlayer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.MediaScriptCommandEventArgs>(
                    h => element.ScriptCommand += h,
                    h => element.ScriptCommand -= h
                );
        }
    }
    public static class TimelineExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> CurrentStateInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentStateInvalidated += h,
                    h => element.CurrentStateInvalidated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> CurrentTimeInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentTimeInvalidated += h,
                    h => element.CurrentTimeInvalidated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> CurrentGlobalSpeedInvalidatedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.CurrentGlobalSpeedInvalidated += h,
                    h => element.CurrentGlobalSpeedInvalidated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> CompletedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Completed += h,
                    h => element.Completed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> RemoveRequestedObservable(this System.Windows.Media.Animation.Timeline element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.RemoveRequested += h,
                    h => element.RemoveRequested -= h
                );
        }
    }
    public static class BitmapSourceExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> DownloadCompletedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DownloadCompleted += h,
                    h => element.DownloadCompleted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Media.Imaging.DownloadProgressEventArgs>> DownloadProgressObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.Imaging.DownloadProgressEventArgs>(
                    h => element.DownloadProgress += h,
                    h => element.DownloadProgress -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Media.ExceptionEventArgs>> DownloadFailedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.DownloadFailed += h,
                    h => element.DownloadFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Media.ExceptionEventArgs>> DecodeFailedObservable(this System.Windows.Media.Imaging.BitmapSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Media.ExceptionEventArgs>(
                    h => element.DecodeFailed += h,
                    h => element.DecodeFailed -= h
                );
        }
    }
    public static class PixelShaderExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> InvalidPixelShaderEncounteredObservable()
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => System.Windows.Media.Effects.PixelShader.InvalidPixelShaderEncountered += h,
                    h => System.Windows.Media.Effects.PixelShader.InvalidPixelShaderEncountered -= h
                );
        }
    }
    public static class FrameworkContentElementExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Data.DataTransferEventArgs>> TargetUpdatedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.TargetUpdated += h,
                    h => element.TargetUpdated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Data.DataTransferEventArgs>> SourceUpdatedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.SourceUpdated += h,
                    h => element.SourceUpdated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> DataContextChangedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.DataContextChanged += h,
                    h => element.DataContextChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> InitializedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Initialized += h,
                    h => element.Initialized -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> LoadedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Loaded += h,
                    h => element.Loaded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnloadedObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unloaded += h,
                    h => element.Unloaded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ToolTipEventArgs>> ToolTipOpeningObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipOpening += h,
                    h => element.ToolTipOpening -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ToolTipEventArgs>> ToolTipClosingObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipClosing += h,
                    h => element.ToolTipClosing -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ContextMenuEventArgs>> ContextMenuOpeningObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuOpening += h,
                    h => element.ContextMenuOpening -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ContextMenuEventArgs>> ContextMenuClosingObservable(this System.Windows.FrameworkContentElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuClosing += h,
                    h => element.ContextMenuClosing -= h
                );
        }
    }
    public static class FrameworkElementExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Data.DataTransferEventArgs>> TargetUpdatedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.TargetUpdated += h,
                    h => element.TargetUpdated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Data.DataTransferEventArgs>> SourceUpdatedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.DataTransferEventArgs>(
                    h => element.SourceUpdated += h,
                    h => element.SourceUpdated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DependencyPropertyChangedEventArgs>> DataContextChangedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(
                    h => element.DataContextChanged += h,
                    h => element.DataContextChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RequestBringIntoViewEventArgs>> RequestBringIntoViewObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs>(
                    h => element.RequestBringIntoView += h,
                    h => element.RequestBringIntoView -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.SizeChangedEventArgs>> SizeChangedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs>(
                    h => element.SizeChanged += h,
                    h => element.SizeChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> InitializedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Initialized += h,
                    h => element.Initialized -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> LoadedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Loaded += h,
                    h => element.Loaded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnloadedObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unloaded += h,
                    h => element.Unloaded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ToolTipEventArgs>> ToolTipOpeningObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipOpening += h,
                    h => element.ToolTipOpening -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ToolTipEventArgs>> ToolTipClosingObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(
                    h => element.ToolTipClosing += h,
                    h => element.ToolTipClosing -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ContextMenuEventArgs>> ContextMenuOpeningObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuOpening += h,
                    h => element.ContextMenuOpening -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ContextMenuEventArgs>> ContextMenuClosingObservable(this System.Windows.FrameworkElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(
                    h => element.ContextMenuClosing += h,
                    h => element.ContextMenuClosing -= h
                );
        }
    }
    public static class VisualStateGroupExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.VisualStateChangedEventArgs>> CurrentStateChangedObservable(this System.Windows.VisualStateGroup element)
        {
            return Observable
                .FromEventPattern<System.Windows.VisualStateChangedEventArgs>(
                    h => element.CurrentStateChanged += h,
                    h => element.CurrentStateChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.VisualStateChangedEventArgs>> CurrentStateChangingObservable(this System.Windows.VisualStateGroup element)
        {
            return Observable
                .FromEventPattern<System.Windows.VisualStateChangedEventArgs>(
                    h => element.CurrentStateChanging += h,
                    h => element.CurrentStateChanging -= h
                );
        }
    }
    public static class WindowExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> SourceInitializedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SourceInitialized += h,
                    h => element.SourceInitialized -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DpiChangedEventArgs>> DpiChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ActivatedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Activated += h,
                    h => element.Activated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> DeactivatedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Deactivated += h,
                    h => element.Deactivated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> StateChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.StateChanged += h,
                    h => element.StateChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> LocationChangedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.LocationChanged += h,
                    h => element.LocationChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.ComponentModel.CancelEventArgs>> ClosingObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                    h => element.Closing += h,
                    h => element.Closing -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ClosedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ContentRenderedObservable(this System.Windows.Window element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.ContentRendered += h,
                    h => element.ContentRendered -= h
                );
        }
    }
    public static class ThumbButtonInfoExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ClickObservable(this System.Windows.Shell.ThumbButtonInfo element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                );
        }
    }
    public static class CollectionViewSourceExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Data.FilterEventArgs>> FilterObservable(this System.Windows.Data.CollectionViewSource element)
        {
            return Observable
                .FromEventPattern<System.Windows.Data.FilterEventHandler, System.Windows.Data.FilterEventArgs>(
                    h => element.Filter += h,
                    h => element.Filter -= h
                );
        }
    }
    public static class NavigationWindowExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigatingCancelEventArgs>> NavigatingObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationProgressEventArgs>> NavigationProgressObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(
                    h => element.NavigationProgress += h,
                    h => element.NavigationProgress -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationFailedEventArgs>> NavigationFailedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(
                    h => element.NavigationFailed += h,
                    h => element.NavigationFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> NavigatedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> LoadCompletedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> NavigationStoppedObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.NavigationStopped += h,
                    h => element.NavigationStopped -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.FragmentNavigationEventArgs>> FragmentNavigationObservable(this System.Windows.Navigation.NavigationWindow element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(
                    h => element.FragmentNavigation += h,
                    h => element.FragmentNavigation -= h
                );
        }
    }
    public static class PageFunctionExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.ReturnEventArgs<T>>> ReturnObservable<T>(this System.Windows.Navigation.PageFunction<T> element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.ReturnEventHandler<T>, System.Windows.Navigation.ReturnEventArgs<T>>(
                    h => element.Return += h,
                    h => element.Return -= h
                );
        }
    }
    public static class HyperlinkExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.RequestNavigateEventArgs>> RequestNavigateObservable(this System.Windows.Documents.Hyperlink element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.RequestNavigateEventHandler, System.Windows.Navigation.RequestNavigateEventArgs>(
                    h => element.RequestNavigate += h,
                    h => element.RequestNavigate -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ClickObservable(this System.Windows.Documents.Hyperlink element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                );
        }
    }
    public static class PageContentExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Documents.GetPageRootCompletedEventArgs>> GetPageRootCompletedObservable(this System.Windows.Documents.PageContent element)
        {
            return Observable
                .FromEventPattern<System.Windows.Documents.GetPageRootCompletedEventHandler, System.Windows.Documents.GetPageRootCompletedEventArgs>(
                    h => element.GetPageRootCompleted += h,
                    h => element.GetPageRootCompleted -= h
                );
        }
    }
    public static class CalendarExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.SelectionChangedEventArgs>> SelectedDatesChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectedDatesChanged += h,
                    h => element.SelectedDatesChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.CalendarDateChangedEventArgs>> DisplayDateChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.CalendarDateChangedEventArgs>(
                    h => element.DisplayDateChanged += h,
                    h => element.DisplayDateChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.CalendarModeChangedEventArgs>> DisplayModeChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.CalendarModeChangedEventArgs>(
                    h => element.DisplayModeChanged += h,
                    h => element.DisplayModeChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> SelectionModeChangedObservable(this System.Windows.Controls.Calendar element)
        {
            return Observable
                .FromEventPattern<System.EventArgs>(
                    h => element.SelectionModeChanged += h,
                    h => element.SelectionModeChanged -= h
                );
        }
    }
    public static class ComboBoxExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> DropDownOpenedObservable(this System.Windows.Controls.ComboBox element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DropDownOpened += h,
                    h => element.DropDownOpened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> DropDownClosedObservable(this System.Windows.Controls.ComboBox element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.DropDownClosed += h,
                    h => element.DropDownClosed -= h
                );
        }
    }
    public static class ContextMenuExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> OpenedObservable(this System.Windows.Controls.ContextMenu element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ClosedObservable(this System.Windows.Controls.ContextMenu element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                );
        }
    }
    public static class ControlExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> PreviewMouseDoubleClickObservable(this System.Windows.Controls.Control element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.PreviewMouseDoubleClick += h,
                    h => element.PreviewMouseDoubleClick -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Input.MouseButtonEventArgs>> MouseDoubleClickObservable(this System.Windows.Controls.Control element)
        {
            return Observable
                .FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(
                    h => element.MouseDoubleClick += h,
                    h => element.MouseDoubleClick -= h
                );
        }
    }
    public static class DataGridExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridColumnEventArgs>> ColumnDisplayIndexChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnEventArgs>(
                    h => element.ColumnDisplayIndexChanged += h,
                    h => element.ColumnDisplayIndexChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowEventArgs>> LoadingRowObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEventArgs>(
                    h => element.LoadingRow += h,
                    h => element.LoadingRow -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowEventArgs>> UnloadingRowObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEventArgs>(
                    h => element.UnloadingRow += h,
                    h => element.UnloadingRow -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowEditEndingEventArgs>> RowEditEndingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowEditEndingEventArgs>(
                    h => element.RowEditEnding += h,
                    h => element.RowEditEnding -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridCellEditEndingEventArgs>> CellEditEndingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellEditEndingEventArgs>(
                    h => element.CellEditEnding += h,
                    h => element.CellEditEnding -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> CurrentCellChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.EventArgs>(
                    h => element.CurrentCellChanged += h,
                    h => element.CurrentCellChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridBeginningEditEventArgs>> BeginningEditObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridBeginningEditEventArgs>(
                    h => element.BeginningEdit += h,
                    h => element.BeginningEdit -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>> PreparingCellForEditObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(
                    h => element.PreparingCellForEdit += h,
                    h => element.PreparingCellForEdit -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.AddingNewItemEventArgs>> AddingNewItemObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.AddingNewItemEventArgs>(
                    h => element.AddingNewItem += h,
                    h => element.AddingNewItem -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InitializingNewItemEventArgs>> InitializingNewItemObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InitializingNewItemEventHandler, System.Windows.Controls.InitializingNewItemEventArgs>(
                    h => element.InitializingNewItem += h,
                    h => element.InitializingNewItem -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>> LoadingRowDetailsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.LoadingRowDetails += h,
                    h => element.LoadingRowDetails -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>> UnloadingRowDetailsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.UnloadingRowDetails += h,
                    h => element.UnloadingRowDetails -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>> RowDetailsVisibilityChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowDetailsEventArgs>(
                    h => element.RowDetailsVisibilityChanged += h,
                    h => element.RowDetailsVisibilityChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.SelectedCellsChangedEventArgs>> SelectedCellsChangedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectedCellsChangedEventHandler, System.Windows.Controls.SelectedCellsChangedEventArgs>(
                    h => element.SelectedCellsChanged += h,
                    h => element.SelectedCellsChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridSortingEventArgs>> SortingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridSortingEventHandler, System.Windows.Controls.DataGridSortingEventArgs>(
                    h => element.Sorting += h,
                    h => element.Sorting -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> AutoGeneratedColumnsObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.AutoGeneratedColumns += h,
                    h => element.AutoGeneratedColumns -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>> AutoGeneratingColumnObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(
                    h => element.AutoGeneratingColumn += h,
                    h => element.AutoGeneratingColumn -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridColumnReorderingEventArgs>> ColumnReorderingObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnReorderingEventArgs>(
                    h => element.ColumnReordering += h,
                    h => element.ColumnReordering -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragStartedEventArgs>> ColumnHeaderDragStartedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventArgs>(
                    h => element.ColumnHeaderDragStarted += h,
                    h => element.ColumnHeaderDragStarted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragDeltaEventArgs>> ColumnHeaderDragDeltaObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventArgs>(
                    h => element.ColumnHeaderDragDelta += h,
                    h => element.ColumnHeaderDragDelta -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragCompletedEventArgs>> ColumnHeaderDragCompletedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventArgs>(
                    h => element.ColumnHeaderDragCompleted += h,
                    h => element.ColumnHeaderDragCompleted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridColumnEventArgs>> ColumnReorderedObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridColumnEventArgs>(
                    h => element.ColumnReordered += h,
                    h => element.ColumnReordered -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridRowClipboardEventArgs>> CopyingRowClipboardContentObservable(this System.Windows.Controls.DataGrid element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridRowClipboardEventArgs>(
                    h => element.CopyingRowClipboardContent += h,
                    h => element.CopyingRowClipboardContent -= h
                );
        }
    }
    public static class DataGridCellExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SelectedObservable(this System.Windows.Controls.DataGridCell element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnselectedObservable(this System.Windows.Controls.DataGridCell element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                );
        }
    }
    public static class DataGridColumnExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>> CopyingCellClipboardContentObservable(this System.Windows.Controls.DataGridColumn element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>(
                    h => element.CopyingCellClipboardContent += h,
                    h => element.CopyingCellClipboardContent -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>> PastingCellClipboardContentObservable(this System.Windows.Controls.DataGridColumn element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DataGridCellClipboardEventArgs>(
                    h => element.PastingCellClipboardContent += h,
                    h => element.PastingCellClipboardContent -= h
                );
        }
    }
    public static class DataGridRowExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SelectedObservable(this System.Windows.Controls.DataGridRow element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnselectedObservable(this System.Windows.Controls.DataGridRow element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                );
        }
    }
    public static class DatePickerExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CalendarClosedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.CalendarClosed += h,
                    h => element.CalendarClosed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CalendarOpenedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.CalendarOpened += h,
                    h => element.CalendarOpened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>> DateValidationErrorObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>(
                    h => element.DateValidationError += h,
                    h => element.DateValidationError -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.SelectionChangedEventArgs>> SelectedDateChangedObservable(this System.Windows.Controls.DatePicker element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectedDateChanged += h,
                    h => element.SelectedDateChanged -= h
                );
        }
    }
    public static class ExpanderExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ExpandedObservable(this System.Windows.Controls.Expander element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Expanded += h,
                    h => element.Expanded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CollapsedObservable(this System.Windows.Controls.Expander element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Collapsed += h,
                    h => element.Collapsed -= h
                );
        }
    }
    public static class FrameExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ContentRenderedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.ContentRendered += h,
                    h => element.ContentRendered -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigatingCancelEventArgs>> NavigatingObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationProgressEventArgs>> NavigationProgressObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(
                    h => element.NavigationProgress += h,
                    h => element.NavigationProgress -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationFailedEventArgs>> NavigationFailedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(
                    h => element.NavigationFailed += h,
                    h => element.NavigationFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> NavigatedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> LoadCompletedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> NavigationStoppedObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.NavigationStopped += h,
                    h => element.NavigationStopped -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.FragmentNavigationEventArgs>> FragmentNavigationObservable(this System.Windows.Controls.Frame element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(
                    h => element.FragmentNavigation += h,
                    h => element.FragmentNavigation -= h
                );
        }
    }
    public static class ImageExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.ExceptionRoutedEventArgs>> ImageFailedObservable(this System.Windows.Controls.Image element)
        {
            return Observable
                .FromEventPattern<System.Windows.ExceptionRoutedEventArgs>(
                    h => element.ImageFailed += h,
                    h => element.ImageFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DpiChangedEventArgs>> DpiChangedObservable(this System.Windows.Controls.Image element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                );
        }
    }
    public static class InkCanvasExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasStrokeCollectedEventArgs>> StrokeCollectedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs>(
                    h => element.StrokeCollected += h,
                    h => element.StrokeCollected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasGestureEventArgs>> GestureObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs>(
                    h => element.Gesture += h,
                    h => element.Gesture -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasStrokesReplacedEventArgs>> StrokesReplacedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokesReplacedEventHandler, System.Windows.Controls.InkCanvasStrokesReplacedEventArgs>(
                    h => element.StrokesReplaced += h,
                    h => element.StrokesReplaced -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Ink.DrawingAttributesReplacedEventArgs>> DefaultDrawingAttributesReplacedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs>(
                    h => element.DefaultDrawingAttributesReplaced += h,
                    h => element.DefaultDrawingAttributesReplaced -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ActiveEditingModeChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.ActiveEditingModeChanged += h,
                    h => element.ActiveEditingModeChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> EditingModeChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.EditingModeChanged += h,
                    h => element.EditingModeChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> EditingModeInvertedChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.EditingModeInvertedChanged += h,
                    h => element.EditingModeInvertedChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventArgs>> SelectionMovingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(
                    h => element.SelectionMoving += h,
                    h => element.SelectionMoving -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> SelectionMovedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionMoved += h,
                    h => element.SelectionMoved -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasStrokeErasingEventArgs>> StrokeErasingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasStrokeErasingEventHandler, System.Windows.Controls.InkCanvasStrokeErasingEventArgs>(
                    h => element.StrokeErasing += h,
                    h => element.StrokeErasing -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> StrokeErasedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.StrokeErased += h,
                    h => element.StrokeErased -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventArgs>> SelectionResizingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(
                    h => element.SelectionResizing += h,
                    h => element.SelectionResizing -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> SelectionResizedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionResized += h,
                    h => element.SelectionResized -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.InkCanvasSelectionChangingEventArgs>> SelectionChangingObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.InkCanvasSelectionChangingEventHandler, System.Windows.Controls.InkCanvasSelectionChangingEventArgs>(
                    h => element.SelectionChanging += h,
                    h => element.SelectionChanging -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> SelectionChangedObservable(this System.Windows.Controls.InkCanvas element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                );
        }
    }
    public static class ListBoxItemExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SelectedObservable(this System.Windows.Controls.ListBoxItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnselectedObservable(this System.Windows.Controls.ListBoxItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                );
        }
    }
    public static class MediaElementExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.ExceptionRoutedEventArgs>> MediaFailedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.ExceptionRoutedEventArgs>(
                    h => element.MediaFailed += h,
                    h => element.MediaFailed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> MediaOpenedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.MediaOpened += h,
                    h => element.MediaOpened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> BufferingStartedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.BufferingStarted += h,
                    h => element.BufferingStarted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> BufferingEndedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.BufferingEnded += h,
                    h => element.BufferingEnded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.MediaScriptCommandRoutedEventArgs>> ScriptCommandObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.MediaScriptCommandRoutedEventArgs>(
                    h => element.ScriptCommand += h,
                    h => element.ScriptCommand -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> MediaEndedObservable(this System.Windows.Controls.MediaElement element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.MediaEnded += h,
                    h => element.MediaEnded -= h
                );
        }
    }
    public static class MenuItemExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ClickObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CheckedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Checked += h,
                    h => element.Checked -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UncheckedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unchecked += h,
                    h => element.Unchecked -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SubmenuOpenedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SubmenuOpened += h,
                    h => element.SubmenuOpened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SubmenuClosedObservable(this System.Windows.Controls.MenuItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SubmenuClosed += h,
                    h => element.SubmenuClosed -= h
                );
        }
    }
    public static class PasswordBoxExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> PasswordChangedObservable(this System.Windows.Controls.PasswordBox element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.PasswordChanged += h,
                    h => element.PasswordChanged -= h
                );
        }
    }
    public static class ScrollViewerExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.ScrollChangedEventArgs>> ScrollChangedObservable(this System.Windows.Controls.ScrollViewer element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs>(
                    h => element.ScrollChanged += h,
                    h => element.ScrollChanged -= h
                );
        }
    }
    public static class ToolTipExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> OpenedObservable(this System.Windows.Controls.ToolTip element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ClosedObservable(this System.Windows.Controls.ToolTip element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                );
        }
    }
    public static class TreeViewExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedPropertyChangedEventArgs<System.Object>>> SelectedItemChangedObservable(this System.Windows.Controls.TreeView element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>>(
                    h => element.SelectedItemChanged += h,
                    h => element.SelectedItemChanged -= h
                );
        }
    }
    public static class TreeViewItemExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ExpandedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Expanded += h,
                    h => element.Expanded -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CollapsedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Collapsed += h,
                    h => element.Collapsed -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SelectedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Selected += h,
                    h => element.Selected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UnselectedObservable(this System.Windows.Controls.TreeViewItem element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unselected += h,
                    h => element.Unselected -= h
                );
        }
    }
    public static class WebBrowserExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigatingCancelEventArgs>> NavigatingObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(
                    h => element.Navigating += h,
                    h => element.Navigating -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> NavigatedObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.Navigated += h,
                    h => element.Navigated -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Navigation.NavigationEventArgs>> LoadCompletedObservable(this System.Windows.Controls.WebBrowser element)
        {
            return Observable
                .FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(
                    h => element.LoadCompleted += h,
                    h => element.LoadCompleted -= h
                );
        }
    }
    public static class ButtonBaseExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> ClickObservable(this System.Windows.Controls.Primitives.ButtonBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Click += h,
                    h => element.Click -= h
                );
        }
    }
    public static class DocumentPageViewExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> PageConnectedObservable(this System.Windows.Controls.Primitives.DocumentPageView element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageConnected += h,
                    h => element.PageConnected -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> PageDisconnectedObservable(this System.Windows.Controls.Primitives.DocumentPageView element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageDisconnected += h,
                    h => element.PageDisconnected -= h
                );
        }
    }
    public static class DocumentViewerBaseExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> PageViewsChangedObservable(this System.Windows.Controls.Primitives.DocumentViewerBase element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.PageViewsChanged += h,
                    h => element.PageViewsChanged -= h
                );
        }
    }
    public static class PopupExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> OpenedObservable(this System.Windows.Controls.Primitives.Popup element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Opened += h,
                    h => element.Opened -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.EventArgs>> ClosedObservable(this System.Windows.Controls.Primitives.Popup element)
        {
            return Observable
                .FromEventPattern<System.EventHandler, System.EventArgs>(
                    h => element.Closed += h,
                    h => element.Closed -= h
                );
        }
    }
    public static class RangeBaseExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedPropertyChangedEventArgs<System.Double>>> ValueChangedObservable(this System.Windows.Controls.Primitives.RangeBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(
                    h => element.ValueChanged += h,
                    h => element.ValueChanged -= h
                );
        }
    }
    public static class ScrollBarExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.ScrollEventArgs>> ScrollObservable(this System.Windows.Controls.Primitives.ScrollBar element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs>(
                    h => element.Scroll += h,
                    h => element.Scroll -= h
                );
        }
    }
    public static class SelectorExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.SelectionChangedEventArgs>> SelectionChangedObservable(this System.Windows.Controls.Primitives.Selector element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                );
        }
    }
    public static class TextBoxBaseExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.TextChangedEventArgs>> TextChangedObservable(this System.Windows.Controls.Primitives.TextBoxBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs>(
                    h => element.TextChanged += h,
                    h => element.TextChanged -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> SelectionChangedObservable(this System.Windows.Controls.Primitives.TextBoxBase element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.SelectionChanged += h,
                    h => element.SelectionChanged -= h
                );
        }
    }
    public static class ThumbExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragStartedEventArgs>> DragStartedObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs>(
                    h => element.DragStarted += h,
                    h => element.DragStarted -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragDeltaEventArgs>> DragDeltaObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs>(
                    h => element.DragDelta += h,
                    h => element.DragDelta -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.Controls.Primitives.DragCompletedEventArgs>> DragCompletedObservable(this System.Windows.Controls.Primitives.Thumb element)
        {
            return Observable
                .FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs>(
                    h => element.DragCompleted += h,
                    h => element.DragCompleted -= h
                );
        }
    }
    public static class ToggleButtonExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> CheckedObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Checked += h,
                    h => element.Checked -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> UncheckedObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Unchecked += h,
                    h => element.Unchecked -= h
                );
        }
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.RoutedEventArgs>> IndeterminateObservable(this System.Windows.Controls.Primitives.ToggleButton element)
        {
            return Observable
                .FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(
                    h => element.Indeterminate += h,
                    h => element.Indeterminate -= h
                );
        }
    }
    public static class HwndHostExtensions
    {
        public static System.IObservable<System.Reactive.EventPattern<System.Windows.DpiChangedEventArgs>> DpiChangedObservable(this System.Windows.Interop.HwndHost element)
        {
            return Observable
                .FromEventPattern<System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(
                    h => element.DpiChanged += h,
                    h => element.DpiChanged -= h
                );
        }
    }
}
