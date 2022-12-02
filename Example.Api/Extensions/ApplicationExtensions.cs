using Autofac;
using Example.Application.Students.Commands;
using Example.Application.Students.Queries;
using Example.Infrastructure.Projections;
using Example.Infrastructure.Repositories;
using MediatR;

namespace Example.Api.Extensions;


public static class ApplicationExtensions
{
    public static ContainerBuilder RegisterMediator(this ContainerBuilder builder)
    {
        builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
        builder.Register<ServiceFactory>(
            context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

        builder.RegisterType<CreateStudentCommandHandler>().AsImplementedInterfaces().InstancePerDependency();
        builder.RegisterType<GetStudentQueryHandler>().AsImplementedInterfaces().InstancePerDependency();

        return builder;
    }

    public static ContainerBuilder RegisterProjections(this ContainerBuilder builder)
    {
        builder.RegisterType<GetStudentProjectionBuilder>().AsImplementedInterfaces().InstancePerDependency();

        return builder;
    }

    public static ContainerBuilder RegisterRepositories(this ContainerBuilder builder)
    {
        builder.RegisterType<StudentRepository>().AsImplementedInterfaces().InstancePerDependency();

        return builder;
    }
}