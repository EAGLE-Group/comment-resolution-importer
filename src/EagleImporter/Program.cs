// <copyright file="Program.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace EagleImporter
{
	using System.Threading.Tasks;
	using Octokit;

	internal class Program
	{
		public static async Task Main()
		{
			GitHubClient client = new GitHubClient(new ProductHeaderValue("EAGLE-importer"));
			Credentials tokenAuth = new Credentials("PLACEHOLDER"); // NOTE: not real credentials
			client.Credentials = tokenAuth;

			ApiClient apiClient = new ApiClient(client, "EAGLE-group", "discussion");

			// TODO: Must have admin rights
			////await client.Repository.Delete("EAGLE-group", "discussion");

			////var newRepository = new NewRepository("discussion");
			////newRepository.Private = true;
			////await client.Repository.Create("EAGLE-group", newRepository);

			await apiClient.GetLabels().ConfigureAwait(false);

			await apiClient.DeleteLabels().ConfigureAwait(false);

			await apiClient.CreateLabels().ConfigureAwait(false);

			await apiClient.GetLabels().ConfigureAwait(false);

			////await apiClient.GetIssues().ConfigureAwait(false);

			////await apiClient.CreateIssue().ConfigureAwait(false);

			////await apiClient.GetIssues().ConfigureAwait(false);
		}
	}
}