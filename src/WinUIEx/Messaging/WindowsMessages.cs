﻿// Based on:

// hardcodet.net NotifyIcon for WPF
// Copyright (c) 2009 - 2013 Philipp Sumi
// Contact and Information: http://www.hardcodet.net
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the Code Project Open License (CPOL);
// either version 1.0 of the License, or (at your option) any later
// version.
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
// THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE

// ReSharper disable InconsistentNaming

using System.Diagnostics.CodeAnalysis;

namespace WinUIEx.Messaging
{
    /// <summary>
    /// This enum defines the windows messages we respond to.
    /// See more on Windows messages <a href="https://docs.microsoft.com/en-us/windows/win32/learnwin32/window-messages">here</a>
    /// </summary>
    internal enum WindowsMessages : uint
    {
        /// <summary>
        /// Sent after a window has been moved.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-move">WM_MOVE message</a>.
        /// </summary>
        WM_MOVE = 3,
        /// <summary>
        /// Sent after a window has been moved.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-moving">WM_MOVING message</a>.
        /// </summary>
        WM_MOVING = 0x0216,
        /// <summary>
        /// Sent to a window after its size has changed.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-size">WM_SIZE message</a>.
        /// </summary>
        WM_SIZE = 4,
        /// <summary>
        /// Sent to a window that the user is resizing. By processing this message, an application can monitor the size and position of the drag rectangle and, if needed, change its size or position.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-sizing">WM_SIZING message</a>.
        /// </summary>
        WM_SIZING = 0x0214,
        /// <summary>
        /// Sent to a window when the size or position of the window is about to change. An application can use this message to override the window's default maximized size and position, or its default minimum or maximum tracking size.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-getminmaxinfo">WM_GETMINMAXINFO message</a>.
        /// </summary>
        WM_GETMINMAXINFO = 0x0024,
        /// <summary>
        /// Sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. This message is sent before the <a href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-enablewindow">EnableWindow</a> function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-enable">WM_ENABLE message</a>.
        /// </summary>
        WM_ENABLE = 0x000A,
        /// <summary>
        /// Sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. 
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-entersizemove">WM_ENTERSIZEMOVE message</a>.
        /// </summary>
        WM_ENTERSIZEMOVE = 0x0231,
        /// <summary>
        /// ent one time to a window, after it has exited the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-exitsizemove">WM_EXITSIZEMOVE message</a>.
        /// </summary>
        WM_EXITSIZEMOVE = 0x0232,
        /// <summary>
        /// Notifies a window that the user clicked the right mouse button (right-clicked) in the window.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-contextmenu">WM_CONTEXTMENU message</a>
        /// 
        /// In case of a notify icon: 
        /// If a user selects a notify icon's shortcut menu with the keyboard, the Shell now sends the associated application a WM_CONTEXTMENU message. Earlier versions send WM_RBUTTONDOWN and WM_RBUTTONUP messages.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/api/shellapi/nf-shellapi-shell_notifyiconw">Shell_NotifyIcon function</a>
        /// </summary>
        WM_CONTEXTMENU = 0x007b,

        /// <summary>
        /// Posted to a window when the cursor moves.
        /// If the mouse is not captured, the message is posted to the window that contains the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-mousemove">WM_MOUSEMOVE message</a>
        /// </summary>
        WM_MOUSEMOVE = 0x0200,

        /// <summary>
        /// Posted when the user presses the left mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// 
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-lbuttondown">WM_LBUTTONDOWN message</a>
        /// </summary>
        WM_LBUTTONDOWN = 0x0201,

        /// <summary>
        /// Posted when the user releases the left mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-lbuttonup">WM_LBUTTONUP message</a>
        /// </summary>
        WM_LBUTTONUP = 0x0202,

        /// <summary>
        /// Posted when the user double-clicks the left mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-lbuttondblclk">WM_LBUTTONDBLCLK message</a>
        /// </summary>
        WM_LBUTTONDBLCLK = 0x0203,

        /// <summary>
        /// Posted when the user presses the right mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-rbuttondown">WM_RBUTTONDOWN message</a>
        /// </summary>
        WM_RBUTTONDOWN = 0x0204,

        /// <summary>
        /// Posted when the user releases the right mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-rbuttonup">WM_RBUTTONUP message</a>
        /// </summary>
        WM_RBUTTONUP = 0x0205,

        /// <summary>
        /// Posted when the user double-clicks the right mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-rbuttondblclk">WM_RBUTTONDBLCLK message</a>
        /// </summary>
        WM_RBUTTONDBLCLK = 0x0206,

        /// <summary>
        /// Posted when the user presses the middle mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-mbuttondown">WM_MBUTTONDOWN message</a>
        /// </summary>
        WM_MBUTTONDOWN = 0x0207,

        /// <summary>
        /// Posted when the user releases the middle mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-mbuttonup">WM_MBUTTONUP message</a>
        /// </summary>
        WM_MBUTTONUP = 0x0208,

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        ///
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-mbuttondblclk">WM_MBUTTONDBLCLK message</a>
        /// </summary>
        WM_MBUTTONDBLCLK = 0x0209,

        /// <summary>
        /// Used to define private messages for use by private window classes, usually of the form WM_USER+x, where x is an integer value.
        /// </summary>
        WM_USER = 0x0400,

        /// <summary>
        /// Associates a new large or small icon with a window. The system displays the large icon in the ALT+TAB dialog box, and the small icon in the window caption.
        /// </summary>
        WM_SETICON = 0x0080,

        /// <summary>
        /// Sent when the effective dots per inch (dpi) for a window has changed. 
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/hidpi/wm-dpichanged">WM_DPICHANGED message</a>.
        /// </summary>
        WM_DPICHANGED = 0x02E0,

        /// <summary>
        /// The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/gdi/wm-displaychange">WM_DISPLAYCHANGE message</a>.
        /// </summary>
        WM_DISPLAYCHANGE = 0x007E,

        /// <summary>
        /// A message that is sent to all top-level windows when the SystemParametersInfo function changes a system-wide setting or when policy settings have changed.
        /// <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-settingchange">WM_SETTINGCHANGE message</a>
        /// </summary>
        WM_SETTINGCHANGE = 0x001A,

        /// <summary>
        /// Broadcast to every window following a theme change event. Examples of theme change events are the activation of a theme, 
        /// the deactivation of a theme, or a transition from one theme to another.
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-themechanged">WM_THEMECHANGE message</a>
        /// </summary>
        WM_THEMECHANGE = 0x031A,

        /// <summary>
        /// This message is only sent when using NOTIFYICON_VERSION_4, the Shell now sends the associated application an NIN_SELECT notification.
        /// Send when a notify icon is activated with mouse or ENTER key.
        /// Earlier versions send WM_RBUTTONDOWN and WM_RBUTTONUP messages.
        /// </summary>
        NIN_SELECT = WM_USER,

        /// <summary>
        /// This message is only sent when using NOTIFYICON_VERSION_4, the Shell now sends the associated application an NIN_SELECT notification.
        /// Send when a notify icon is activated with SPACEBAR or ENTER key.
        /// Earlier versions send WM_RBUTTONDOWN and WM_RBUTTONUP messages.
        /// </summary>
        NIN_KEYSELECT = WM_USER + 1,

        /// <summary>
        /// Sent when the balloon is shown (balloons are queued).
        /// </summary>
        NIN_BALLOONSHOW = WM_USER + 2,

        /// <summary>
        /// Sent when the balloon disappears. For example, when the icon is deleted.
        /// This message is not sent if the balloon is dismissed because of a timeout or if the user clicks the mouse.
        ///
        /// As of Windows 7, NIN_BALLOONHIDE is also sent when a notification with the NIIF_RESPECT_QUIET_TIME flag set attempts to display during quiet time (a user's first hour on a new computer).
        /// In that case, the balloon is never displayed at all.
        /// </summary>
        NIN_BALLOONHIDE = WM_USER + 3,

        /// <summary>
        /// Sent when the balloon is dismissed because of a timeout.
        /// </summary>
        NIN_BALLOONTIMEOUT = WM_USER + 4,

        /// <summary>
        /// Sent when the balloon is dismissed because the user clicked the mouse.
        /// </summary>
        NIN_BALLOONUSERCLICK = WM_USER + 5,

        /// <summary>
        /// Sent when the user hovers the cursor over an icon to indicate that the richer pop-up UI should be used in place of a standard textual tooltip.
        /// </summary>
        NIN_POPUPOPEN = WM_USER + 6,

        /// <summary>
        /// Sent when a cursor no longer hovers over an icon to indicate that the rich pop-up UI should be closed.
        /// </summary>
        NIN_POPUPCLOSE = WM_USER + 7,
    }
}