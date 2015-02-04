﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using CronExpressionDescriptor;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");










            
            #line 10 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Recurring jobs" };
	List<RecurringJobDto> recurringJobs;

	using (var connection = Storage.GetConnection())
	{
		recurringJobs = connection.GetRecurringJobs();
	}


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 20 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
 if (recurringJobs.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        No recurring jobs found.\r\n    </div>\r" +
"\n");


            
            #line 25 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"js-jobs-list\">\r\n        <div class=\"btn-toolbar btn-toolbar-top\">" +
"\r\n            <button class=\"js-jobs-list-command btn btn-sm btn-primary\"\r\n     " +
"               data-url=\"");


            
            #line 31 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                         Write(Request.LinkTo("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                    data-loading-text=""Triggering..."">
                <span class=""glyphicon glyphicon-play-circle""></span>
                Trigger now
            </button>

            <button class=""js-jobs-list-command btn btn-sm btn-default""
                    data-url=""");


            
            #line 38 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                         Write(Request.LinkTo("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                    data-loading-text=""Removing...""
                    data-confirm=""Do you really want to REMOVE ALL selected jobs?"">
                <span class=""glyphicon glyphicon-remove""></span>
                Remove
            </button>
        </div>

        <table class=""table"">
            <thead>
                <tr>
                    <th class=""min-width"">
                        <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                    </th>
                    <th class=""min-width"">Id</th>
                    <th class=""min-width"">Cron (UTC)</th>
                    <th>Job</th>
                    <th class=""align-right min-width"">Next execution</th>
                    <th class=""align-right min-width"">Last execution</th>
                </tr>
            </thead>
            <tbody>
");


            
            #line 60 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                 foreach (var job in recurringJobs)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr class=\"js-jobs-list-row hover\">\r\n                        " +
"<td>\r\n                            <input type=\"checkbox\" class=\"js-jobs-list-che" +
"ckbox\" name=\"jobs[]\" value=\"");


            
            #line 64 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                 Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                        </td>\r\n                        <td class=\"min-width" +
"\">");


            
            #line 66 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td class=\"min-width\">");


            
            #line 67 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(ExpressionDescriptor.GetDescription(job.Cron));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>\r\n");


            
            #line 69 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             if (job.Job != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral(" ");


            
            #line 71 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                              Write(HtmlHelper.DisplayJob(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 72 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>");


            
            #line 75 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 76 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td class=\"align-right min" +
"-width\">\r\n");


            
            #line 79 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             if (job.NextExecution != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span data-moment=\"");


            
            #line 81 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                               Write(JobHelper.ToTimestamp(job.NextExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 82 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(job.NextExecution.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n");


            
            #line 84 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>N/A</em>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td class=\"align-right min" +
"-width\">\r\n");


            
            #line 91 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             if (job.LastExecution != null)
                            {
                                if (!String.IsNullOrEmpty(job.LastJobId))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a href=\"");


            
            #line 95 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        Write(Request.LinkTo("/job/" + job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        <span class=\"label label-default labe" +
"l-hover\" data-moment=\"");


            
            #line 96 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                               Write(JobHelper.ToTimestamp(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"");


            
            #line 96 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                                         Write(job.LastJobState != null && JobHistoryRenderer.ForegroundStateColors.ContainsKey(job.LastJobState) ? String.Format("background-color: {0};", JobHistoryRenderer.ForegroundStateColors[job.LastJobState]) : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            ");


            
            #line 97 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(job.LastExecution.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </span>\r\n                              " +
"      </a>\r\n");


            
            #line 100 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <em>\r\n                                       " +
" Canceled\r\n                                        <span data-moment=\"");


            
            #line 105 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                       Write(JobHelper.ToTimestamp(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            ");


            
            #line 106 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(job.LastExecution.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </span>\r\n                              " +
"      </em>\r\n");


            
            #line 109 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>N/A</em>\r\n");


            
            #line 114 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                    </tr>\r\n");


            
            #line 117 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");


            
            #line 121 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    ");


        }
    }
}
#pragma warning restore 1591
