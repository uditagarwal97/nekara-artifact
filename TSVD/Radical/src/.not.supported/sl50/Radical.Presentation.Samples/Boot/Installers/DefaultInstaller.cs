﻿using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Topics.Radical.ComponentModel;
using Topics.Radical.ComponentModel.Messaging;
using Topics.Radical.Messaging;
using Topics.Radical.Windows.Threading;

namespace Topics.Radical.Windows.Presentation.Boot.Installers
{
	/// <summary>
	/// A Windsor installer.
	/// </summary>
	[Export( typeof( IWindsorInstaller ) )]
	public class DefaultInstaller : IWindsorInstaller
	{
		/// <summary>
		/// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="store">The configuration store.</param>
		public void Install( Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store )
		{
			//container.Register
			//(
			//    Component.For<TraceSource>()
			//        .UsingFactoryMethod( () => new TraceSource( "default-trace" ) )
			//        .LifeStyle.Is( LifestyleType.Singleton )
			//);

			container.Register(
				Component.For<Application>()
					.UsingFactoryMethod( () => Application.Current )
					.LifeStyle.Is( LifestyleType.Singleton ),

				Component.For<Dispatcher>()
					.UsingFactoryMethod( () => Deployment.Current.Dispatcher )
					.LifeStyle.Is( LifestyleType.Singleton )
			);

			container.Register(
				Component.For<IDispatcher>()
					.ImplementedBy<SilverlightDispatcher>()
					.LifeStyle.Is( LifestyleType.Singleton ),

				Component.For<IMessageBroker>()
					.ImplementedBy<MessageBroker>()
					.LifeStyle.Is( LifestyleType.Singleton )
			);
		}
	}
}