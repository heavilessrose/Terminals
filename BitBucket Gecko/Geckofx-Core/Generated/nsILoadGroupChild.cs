// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsILoadGroupChild.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// nsILoadGroupChild provides a hierarchy of load groups so that the
    /// root load group can be used to conceptually tie a series of loading
    /// operations into a logical whole while still leaving them separate
    /// for the purposes of cancellation and status events.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("02efe8e2-fbbc-4718-a299-b8a09c60bf6b")]
	public interface nsILoadGroupChild
	{
		
		/// <summary>
        /// The parent of this load group. It is stored with
        /// a nsIWeakReference/nsWeakPtr so there is no requirement for the
        /// parentLoadGroup to out live the child, nor will the child keep a
        /// reference count on the parent.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetParentLoadGroupAttribute();
		
		/// <summary>
        /// The parent of this load group. It is stored with
        /// a nsIWeakReference/nsWeakPtr so there is no requirement for the
        /// parentLoadGroup to out live the child, nor will the child keep a
        /// reference count on the parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aParentLoadGroup);
		
		/// <summary>
        /// The nsILoadGroup associated with this nsILoadGroupChild
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetChildLoadGroupAttribute();
		
		/// <summary>
        /// The rootLoadGroup is the recursive parent of this
        /// load group where parent is defined as parentlLoadGroup if set
        /// or childLoadGroup.loadGroup as a backup. (i.e. parentLoadGroup takes
        /// precedence.) The nsILoadGroup child is the root if neither parent
        /// nor loadgroup attribute is specified.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetRootLoadGroupAttribute();
	}
}