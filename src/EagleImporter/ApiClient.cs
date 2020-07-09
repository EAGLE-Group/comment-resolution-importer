// <copyright file="ApiClient.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace EagleImporter
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Octokit;

	public class ApiClient
	{
		public ApiClient(GitHubClient client, string owner, string repo)
		{
			Client = client;
			Owner = owner;
			Repo = repo;
		}

		public GitHubClient Client { get; }

		public string Owner { get; }

		public string Repo { get; }

		public async Task CreateIssue()
		{
			NewIssue newIssue = new NewIssue("Title");
			newIssue.Body = @"# Description";
			newIssue.Labels.Add("category-conceptual");
			newIssue.Labels.Add("context-model");

			await Client.Issue.Create(Owner, Repo, newIssue).ConfigureAwait(false);
		}

		public async Task CreateLabels()
		{
			foreach (NewLabel label in EagleLabels.DefaultLabels)
			{
				await Client.Issue.Labels.Create(Owner, Repo, label).ConfigureAwait(false);
			}
		}

		public async Task DeleteLabels()
		{
			IReadOnlyList<Label> labels = await Client.Issue.Labels.GetAllForRepository(Owner, Repo).ConfigureAwait(false);

			foreach (Label label in labels)
			{
				await Client.Issue.Labels.Delete(Owner, Repo, label.Name).ConfigureAwait(false);
			}
		}

		public async Task GetIssues()
		{
			IReadOnlyList<Issue> issuesForOctokit = await Client.Issue.GetAllForRepository(Owner, Repo).ConfigureAwait(false);

			foreach (Issue issue in issuesForOctokit)
			{
				Console.WriteLine($"#{issue.Number}, {issue.Title}, {string.Join("|", issue.Labels.Select(x => x.Name))}");
			}
		}

		public async Task GetLabels()
		{
			IReadOnlyList<Label> labels = await Client.Issue.Labels.GetAllForRepository(Owner, Repo).ConfigureAwait(false);

			foreach (Label label in labels)
			{
				Console.WriteLine($"{label.Name}, {label.Color}");
			}
		}
	}
}