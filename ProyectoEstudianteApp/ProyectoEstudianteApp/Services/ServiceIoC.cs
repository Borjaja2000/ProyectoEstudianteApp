using Autofac;
using ProyectoEstudianteApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEstudianteApp.Services
{
    public class ServiceIoC
    {
        IContainer container;

        public ServiceIoC()
        {
            this.RegisterDependencies();
        }
        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<TareasViewModel>();
            builder.RegisterType<TareaEditarViewModel>();
            builder.RegisterType<ServiceEstudiante>();
            builder.RegisterType<TareaViewModel>();
            builder.RegisterType<UsuariosViewModel>();
            builder.RegisterType<AddUsuarioViewModel>();
            this.container = builder.Build();
        }
        
        public TareaViewModel TareaViewModel
        {
            get
            {
                return this.container.Resolve<TareaViewModel>();
            }
        }

        public TareasViewModel TareasViewModel
        {
            get
            {
                return this.container.Resolve<TareasViewModel>();
            }
        }

        public TareaEditarViewModel TareaEditarViewModel
        {
            get
            {
                return this.container.Resolve<TareaEditarViewModel>();
            }
        }

        public AddUsuarioViewModel AddUsuarioViewModel
        {
            get
            {
                return this.container.Resolve<AddUsuarioViewModel>();
            }
        }

        public UsuariosViewModel UsuariosViewModel
        {
            get
            {
                return this.container.Resolve<UsuariosViewModel>();
            }
        }
    }
}
