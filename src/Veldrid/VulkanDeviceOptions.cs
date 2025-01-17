using System;
using TerraFX.Interop.Vulkan;

namespace Veldrid
{
    /// <summary>
    /// A structure describing Vulkan-specific device creation options.
    /// </summary>
    public struct VulkanDeviceOptions
    {
        /// <summary>
        /// An array of required Vulkan instance extensions. Entries in this array will be enabled in the <see cref="GraphicsDevice"/>'s
        /// created <see cref="VkInstance"/>.
        /// </summary>
        public string[] InstanceExtensions;

        /// <summary>
        /// An array of required Vulkan device extensions. Entries in this array will be enabled in the <see cref="GraphicsDevice"/>'s
        /// created <see cref="VkDevice"/>.
        /// </summary>
        public string[] DeviceExtensions;

        /// <summary>
        /// A little hack for OpenXR support. Allows the user to supply their own function
        /// to create a physical device.
        /// </summary>
        public Func<IntPtr, VkPhysicalDevice[], IntPtr>? GetPhysicalDevice;

        /// <summary>
        /// Constructs a new <see cref="VulkanDeviceOptions"/>.
        /// </summary>
        /// <param name="instanceExtensions">
        /// An array of required Vulkan instance extensions. Entries in this array will be
        /// enabled in the <see cref="GraphicsDevice"/>'s created <see cref="VkInstance"/>.
        /// </param>
        /// <param name="deviceExtensions">
        /// An array of required Vulkan device extensions. Entries in this array will be enabled
        /// in the <see cref="GraphicsDevice"/>'s created <see cref="VkDevice"/>.
        /// </param>
        public VulkanDeviceOptions(string[] instanceExtensions, string[] deviceExtensions)
        {
            InstanceExtensions = instanceExtensions;
            DeviceExtensions = deviceExtensions;
        }
    }
}
