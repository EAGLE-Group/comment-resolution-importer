// <copyright file="EagleLabels.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace EagleImporter
{
	using System.Collections.Generic;
	using Octokit;

	public static class EagleLabels
	{
		public static readonly List<NewLabel> DefaultLabels = new List<NewLabel>();

		static EagleLabels()
		{
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-conceptual"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-content"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-crosslink"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-data-policy"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-development"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-documentation"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-editorial"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-method"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-programming"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-structure"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "category-UML-model-structure"));

			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "context-bar-coding"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "context-database"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "context-uml-model"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "context-matrix"));

			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-gen"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-agri"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-docu"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-ecol"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-forest"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-format"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-geol"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-hab"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-hyd"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-ind"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-meta"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-oth"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-pol"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-soil"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-sport"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-tech"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-temp"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-trans"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-urb"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "theme-veg"));

			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-grid"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-lcc"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-lch"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-lcu"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-lua"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "element-uml"));

			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "status-agreed"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "status-open"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "status-solved"));

			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-closed"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-in-progress"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-momentary-solved"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-new"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-obsolete"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-partly-solved"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-pending"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-postponed"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-redundant"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-rejected"));
			EagleLabels.DefaultLabels.Add(new NewLabel(color: "cccccc", name: "substatus-under-discussion"));
		}
	}
}