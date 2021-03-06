//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Xamarin.MSBuild
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "PolicheckHtmlTemplate.cshtml"
using System.IO;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
internal partial class PolicheckHtmlTemplate : PolicheckHtmlTemplateBase
{

#line hidden

#line 2 "PolicheckHtmlTemplate.cshtml"
public IEnumerable<Xamarin.MSBuild.PolicheckTerm> Model { get; set; }

#line default
#line hidden


#line 5 "PolicheckHtmlTemplate.cshtml"
public static Action<System.IO.TextWriter> GetSeverityHtml (int severity) {
#line default
#line hidden
return new Action<System.IO.TextWriter>(__razor_helper_writer => {

#line 5 "PolicheckHtmlTemplate.cshtml"
                                        
    switch (severity) {
    case 1:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <abbr>Very High Risk</abbr>");


#line 8 "PolicheckHtmlTemplate.cshtml"
                                   ;
        break;
    case 2:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <abbr>High Risk</abbr>\n");


#line 12 "PolicheckHtmlTemplate.cshtml"
        break;
    case 3:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <abbr>Moderate Risk</abbr>\n");


#line 15 "PolicheckHtmlTemplate.cshtml"
        break;
    default:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <abbr>");


#line 17 "PolicheckHtmlTemplate.cshtml"
WriteTo(__razor_helper_writer, severity);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</abbr>\n");


#line 18 "PolicheckHtmlTemplate.cshtml"
        break;
    }


#line default
#line hidden
});

#line 20 "PolicheckHtmlTemplate.cshtml"
}
#line default
#line hidden


public override void Execute()
{
WriteLiteral("\n<html>\n    <head>\n        <link");

WriteLiteral(" rel=\'stylesheet\'");

WriteLiteral(" href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\'");

WriteLiteral(" \n              integrity=\'sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+P" +
"mSTsz/K68vbdEjh4u\'");

WriteLiteral(" crossorigin=\'anonymous\'");

WriteLiteral(">\n        <style");

WriteLiteral(" type=\'text/css\'");

WriteLiteral(">\n            .table {\n                max-width: none;\n                table-lay" +
"out: fixed;\n                word-wrap: break-word;\n            }\n        </style" +
">\n    </head>\n    <body>\n        <div");

WriteLiteral(" class=\'container-fluid\'");

WriteLiteral(">\n            <h1>Policheck Results</h1>\n            <table");

WriteLiteral(" class=\'table table-bordered table-condensed\'");

WriteLiteral(" style=\'width: auto !important\'");

WriteLiteral(@">
                <thead>
                    <tr>
                        <th></th>
                        <th>Term</th>
                        <th>Severity</th>
                        <th># of Occurrences</th>
                        <th>Term Link</th>
                    </tr>
                </thead>
                <tbody>
");


#line 48 "PolicheckHtmlTemplate.cshtml"
                    

#line default
#line hidden

#line 48 "PolicheckHtmlTemplate.cshtml"
                     foreach (var term in Model) {
                        var termUrl = term.Comment.Split('-')[1].Trim ();



#line default
#line hidden
WriteLiteral("                        <tr>\n                            <td");

WriteLiteral(" style=\'width: auto !important;\'");

WriteLiteral(" rowspan=\'3\'");

WriteLiteral(">\n                                <h3>&gt;</h3>\n                            </td>" +
"\n                            <td>");


#line 55 "PolicheckHtmlTemplate.cshtml"
                           Write(term.TermDefinition);


#line default
#line hidden
WriteLiteral("</td>\n                            <td>");


#line 56 "PolicheckHtmlTemplate.cshtml"
                           Write(GetSeverityHtml(term.Severity));


#line default
#line hidden
WriteLiteral("</td>\n                            <td>");


#line 57 "PolicheckHtmlTemplate.cshtml"
                           Write(term.RowCount);


#line default
#line hidden
WriteLiteral("</td>\n                            <td><a");

WriteAttribute ("href", " href=\"", "\""

#line 58 "PolicheckHtmlTemplate.cshtml"
  , Tuple.Create<string,object,bool> ("", termUrl

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 58 "PolicheckHtmlTemplate.cshtml"
                                              Write(termUrl);


#line default
#line hidden
WriteLiteral("</a></td>\n                        </tr>\n");


#line 60 "PolicheckHtmlTemplate.cshtml"



#line default
#line hidden
WriteLiteral("                        <tr>\n                            <td");

WriteLiteral(" colspan=\'4\'");

WriteLiteral(">\n                                <table");

WriteLiteral(" class=\'table table-condensed\'");

WriteLiteral(" style=\'width: 100% !important;\'");

WriteLiteral(@">
                                    <thead>
                                        <tr>
                                            <th>Url</th>
                                            <th>Context</th>
                                            <th>Position</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");


#line 72 "PolicheckHtmlTemplate.cshtml"
                                    

#line default
#line hidden

#line 72 "PolicheckHtmlTemplate.cshtml"
                                     foreach (var occurrence in term.Occurrences) {
                                        var file = Path.DirectorySeparatorChar == '\\'
                                            ? Path.GetFileName (occurrence.Url)
                                            : occurrence.Url.Split('\\').Last ();


#line default
#line hidden
WriteLiteral("                                        <tr>\n                                    " +
"        <td>");


#line 77 "PolicheckHtmlTemplate.cshtml"
                                           Write(file);


#line default
#line hidden
WriteLiteral("</td>\n                                            <td>");


#line 78 "PolicheckHtmlTemplate.cshtml"
                                           Write(occurrence.Context);


#line default
#line hidden
WriteLiteral("</td>\n                                            <td>");


#line 79 "PolicheckHtmlTemplate.cshtml"
                                            Write(occurrence.Position.Replace(":", string.Empty));


#line default
#line hidden
WriteLiteral(", column ");


#line 79 "PolicheckHtmlTemplate.cshtml"
                                                                                              Write(occurrence.Column);


#line default
#line hidden
WriteLiteral("</td>\n                                        </tr>\n");


#line 81 "PolicheckHtmlTemplate.cshtml"
                                    }


#line default
#line hidden
WriteLiteral("                                    </tbody>\n                                </ta" +
"ble>\n                            </td>\n                        </tr>\n");


#line 86 "PolicheckHtmlTemplate.cshtml"



#line default
#line hidden
WriteLiteral("                        <tr>\n                            <td");

WriteLiteral(" colspan=\'4\'");

WriteLiteral(">\n                                <table");

WriteLiteral(" class=\'table table-condensed\'");

WriteLiteral(" style=\'width: 100% !important;\'");

WriteLiteral(@">
                                    <thead>
                                        <tr>
                                            <th>Context</th>
                                            <th>Recommendation</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");


#line 97 "PolicheckHtmlTemplate.cshtml"
                                    

#line default
#line hidden

#line 97 "PolicheckHtmlTemplate.cshtml"
                                     foreach (var action in term.Actions) {


#line default
#line hidden
WriteLiteral("                                        <tr>\n                                    " +
"        <td>");


#line 99 "PolicheckHtmlTemplate.cshtml"
                                           Write(action.Context);


#line default
#line hidden
WriteLiteral("</td>\n                                            <td>");


#line 100 "PolicheckHtmlTemplate.cshtml"
                                                   WriteLiteral(action.Recommendation);

#line default
#line hidden
WriteLiteral("</td>\n                                        </tr>\n");


#line 102 "PolicheckHtmlTemplate.cshtml"
                                    }


#line default
#line hidden
WriteLiteral("                                    </tbody>\n                                </ta" +
"ble>\n                            </td>\n                        </tr>\n");


#line 107 "PolicheckHtmlTemplate.cshtml"
                    }


#line default
#line hidden
WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </body>\n</html>");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
internal abstract class PolicheckHtmlTemplateBase
{

        // This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
        //
        System.IO.TextWriter __razor_writer;

        // This method is OPTIONAL
        //
        /// <summary>Executes the template and returns the output as a string.</summary>
        /// <returns>The template output.</returns>
        public string GenerateString ()
        {
            using (var sw = new System.IO.StringWriter ()) {
                Generate (sw);
                return sw.ToString ();
            }
        }

        // This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
        // and provide another means of invoking Execute.
        //
        /// <summary>Executes the template, writing to the provided text writer.</summary>
        /// <param name="writer">The TextWriter to which to write the template output.</param>
        public void Generate (System.IO.TextWriter writer)
        {
            __razor_writer = writer;
            Execute ();
            __razor_writer = null;
        }

        // This method is REQUIRED, but you may choose to implement it differently
        //
        /// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
        /// <param name="value">The literal value.</param>
        protected void WriteLiteral (string value)
        {
            __razor_writer.Write (value);
        }

        // This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
        //
        /// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
        /// <param name="writer">The TextWriter to which to write the literal.</param>
        /// <param name="value">The literal value.</param>
        protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
        {
            writer.Write (value);
        }

        // This method is REQUIRED, but you may choose to implement it differently
        //
        /// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
        /// <param name="value">The value.</param>
        /// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
        protected void Write (object value)
        {
            WriteTo (__razor_writer, value);
        }

        // This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
        //
        /// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
        /// <param name="writer">The TextWriter to which to write the value.</param>
        /// <param name="value">The value.</param>
        /// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
        protected static void WriteTo (System.IO.TextWriter writer, object value)
        {
            if (value == null)
                return;

            var write = value as Action<System.IO.TextWriter>;
            if (write != null) {
                write (writer);
                return;
            }

            //NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
            //instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
            writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
        }

        // This method is REQUIRED, but you may choose to implement it differently
        //
        /// <summary>
        /// Conditionally writes an attribute to the template output.
        /// </summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="prefix">The prefix of the attribute.</param>
        /// <param name="suffix">The suffix of the attribute.</param>
        /// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
        protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
        {
            WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
        }

        // This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
        //
        /// <summary>
        /// Conditionally writes an attribute to a TextWriter.
        /// </summary>
        /// <param name="writer">The TextWriter to which to write the attribute.</param>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="prefix">The prefix of the attribute.</param>
        /// <param name="suffix">The suffix of the attribute.</param>
        /// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
        ///<remarks>Used by Razor helpers to write attributes.</remarks>
        protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
        {
            // this is based on System.Web.WebPages.WebPageExecutingBase
            // Copyright (c) Microsoft Open Technologies, Inc.
            // Licensed under the Apache License, Version 2.0
            if (values.Length == 0) {
                // Explicitly empty attribute, so write the prefix and suffix
                writer.Write (prefix);
                writer.Write (suffix);
                return;
            }

            bool first = true;
            bool wroteSomething = false;

            for (int i = 0; i < values.Length; i++) {
                Tuple<string,object,bool> attrVal = values [i];
                string attPrefix = attrVal.Item1;
                object value = attrVal.Item2;
                bool isLiteral = attrVal.Item3;

                if (value == null) {
                    // Nothing to write
                    continue;
                }

                // The special cases here are that the value we're writing might already be a string, or that the 
                // value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
                // of the string 'true'. If the value is the bool 'false' we don't want to write anything.
                //
                // Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
                string stringValue;
                bool? boolValue = value as bool?;
                if (boolValue == true) {
                    stringValue = name;
                } else if (boolValue == false) {
                    continue;
                } else {
                    stringValue = value as string;
                }

                if (first) {
                    writer.Write (prefix);
                    first = false;
                } else {
                    writer.Write (attPrefix);
                }

                if (isLiteral) {
                    writer.Write (stringValue ?? value);
                } else {
                    WriteTo (writer, stringValue ?? value);
                }
                wroteSomething = true;
            }
            if (wroteSomething) {
                writer.Write (suffix);
            }
        }
        // This method is REQUIRED. The generated Razor subclass will override it with the generated code.
        //
        ///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
        ///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
        public abstract void Execute ();

}
}
#pragma warning restore 1591
