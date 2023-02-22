namespace FuelStation.Blazor.Server.Services {

    public class AuthorizationService {

        public void AddAuthorizationPolicies(IServiceCollection services) {

            services.AddAuthorization(options => {

                options.AddPolicy("Manager", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("EmployeeType", "Manager");
                });

                options.AddPolicy("Staff", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("EmployeeType", "Staff");
                });

                options.AddPolicy("Cashier", policy => {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("EmployeeType", "Cashier");
                });

            });

        }

    }

}