/// Copyright 2007-2008 The Apache Software Foundation.
/// 
/// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
/// this file except in compliance with the License. You may obtain a copy of the 
/// License at 
/// 
///   http://www.apache.org/licenses/LICENSE-2.0 
/// 
/// Unless required by applicable law or agreed to in writing, software distributed 
/// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
/// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
/// specific language governing permissions and limitations under the License.

namespace MassTransit.ServiceBus
{
	/// <summary>
	/// This interface should be implemented by classes that want to automatically register
	/// message consumers with the service bus when loaded. The service bus bootloader will
	/// enumerate the classes in any references assemblies to determine if the interface is 
	/// supported and call those classes to register their handlers on the service bus.
	/// </summary>
	public interface IAutoSubscriber
	{
        /// <summary>
        /// Used to subscribe or unsubscribe at startup
        /// </summary>
        /// <param name="bus">The funk bus</param>
	    void Initialize(IServiceBus bus);
	}
}