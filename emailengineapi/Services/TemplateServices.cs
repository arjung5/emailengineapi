﻿using emailengineapi.Model;
using Newtonsoft.Json;
using PreMailer.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace emailengineapi.Services
{
    public class TemplateServices
    {
        public async Task<string> BuildTemplate()
        {
            JsonStructure jsonStructure = new JsonStructure();
            jsonStructure.Section = new Section();
            jsonStructure.Section.Type = "body";
            jsonStructure.Section.ChildSections = new List<Section>();

            Section spacer1 = new Section();
            jsonStructure.Section.ChildSections.Add(spacer1);
            spacer1.Type = "spacer";
            spacer1.CssClass = "float-center";
            spacer1.ChildSections = new List<Section>();

            Section spacerInner = new Section();
            spacer1.ChildSections.Add(spacerInner);
            spacerInner.Type = "spacerHeight";
            spacerInner.Property = "height";
            spacerInner.PropertyValue = "16px";
            spacerInner.Value = "&nbsp";

            Section container = new Section();
            jsonStructure.Section.ChildSections.Add(container);
            container.Type = "container";
            container.CssClass = "float-center";
            container.Property = "align";
            container.PropertyValue = "center";
            container.ChildSections = new List<Section>();


            Section row1 = new Section();
            row1.Type = "row";
            row1.CssClass = "header";
            row1.ChildSections = new List<Section>();
            container.ChildSections.Add(row1);

            Section row1Column1 = new Section();
            row1.ChildSections.Add(row1Column1);
            row1Column1.Type = "column";
            row1Column1.CssClass = "small-12 large-12 columns first last";
            row1Column1.Elements = new List<Element>();



            Element spacer2 = new Element();
            row1Column1.Elements.Add(spacer2);
            spacer2.Type = "spacer";
            spacer2.CssClass = "float-center";
            spacer2.Elements = new List<Element>();

            Element spacerInner2 = new Element();
            spacer2.Elements.Add(spacerInner2);
            spacerInner2.Type = "spacerHeight";
            spacerInner2.Property = "height";
            spacerInner2.PropertyValue = "16px";
            spacerInner2.Value = "&nbsp";



            Element element = new Element();
            row1Column1.Elements.Add(element);
            element.Type = "h4";
            element.CssClass = "text-center";
            element.Value = "Pirate Retirement Services";


            Section row2 = new Section();
            row2.Type = "row";
            container.ChildSections.Add(row2);
            row2.ChildSections = new List<Section>();


            Section spacerRow = new Section();
            spacerRow.Type = "spacer";
            spacerRow.CssClass = "float-center";
            container.ChildSections.Add(spacerRow);
            spacerRow.ChildSections = new List<Section>();

            Section spacerRowInner = new Section();
            spacerRowInner.Type = "spacerHeight";
            spacerRowInner.Property = "height";
            spacerRowInner.PropertyValue = "16px";
            spacerRow.ChildSections.Add(spacerRowInner);
            spacerRowInner.Value = "&nbsp";


            Section row2Column1 = new Section();
            row2Column1.Type = "column";
            row2Column1.CssClass = "small-12 large-12 columns first last";
            row2.ChildSections.Add(row2Column1);
            row2Column1.Elements = new List<Element>();



            Element spacer3 = new Element();
            row2Column1.Elements.Add(spacer3);
            spacer3.Type = "spacer";
            spacer3.CssClass = "float-center";
            spacer3.Elements = new List<Element>();

            Element spacerInner3 = new Element();
            spacer3.Elements.Add(spacerInner3);
            spacerInner3.Type = "spacerHeight";
            spacerInner3.Property = "height";
            spacerInner3.PropertyValue = "16px";
            spacerInner3.Value = "&nbsp";

            Element row2Column1Element1 = new Element();
            row2Column1.Elements.Add(row2Column1Element1);
            row2Column1Element1.Type = "center";
            row2Column1Element1.Elements = new List<Element>();

            Element row2Column1Element1Inner1 = new Element();
            row2Column1Element1.Elements.Add(row2Column1Element1Inner1);
            row2Column1Element1Inner1.Type = "img";
            row2Column1Element1Inner1.Property = "align";
            row2Column1Element1Inner1.PropertyValue = "center";
            row2Column1Element1Inner1.CssClass = "float-center";
            row2Column1Element1Inner1.imageUrl = "https://placehold.it/250x250";



            Element spacer4 = new Element();
            row2Column1.Elements.Add(spacer4);
            spacer4.Type = "spacer";
            spacer4.CssClass = "float-center";
            spacer4.Elements = new List<Element>();

            Element spacerInner4 = new Element();
            spacer4.Elements.Add(spacerInner3);
            spacerInner4.Type = "spacerHeight";
            spacerInner4.Property = "height";
            spacerInner4.PropertyValue = "16px";
            spacerInner4.Value = "&nbsp";


            Element row2Column1Element2 = new Element();
            row2Column1.Elements.Add(row2Column1Element2);
            row2Column1Element2.Type = "h1";
            row2Column1Element2.CssClass = "text-center";
            row2Column1Element2.Value = "Forgot Your Password?";


            Element spacer5 = new Element();
            row2Column1.Elements.Add(spacer5);
            spacer5.Type = "spacer";
            spacer5.CssClass = "float-center";
            spacer5.Elements = new List<Element>();

            Element spacerInner5 = new Element();
            spacer5.Elements.Add(spacerInner5);
            spacerInner5.Type = "spacerHeight";
            spacerInner5.Property = "height";
            spacerInner5.PropertyValue = "16px";
            spacerInner5.Value = "&nbsp";


            Element row2Column1Element3 = new Element();
            row2Column1.Elements.Add(row2Column1Element3);
            row2Column1Element3.Type = "p";
            row2Column1Element3.CssClass = "text-center";
            row2Column1Element3.Value = "It happens. Click the link below to reset your password.";



            Element row2Column1Element4 = new Element();
            row2Column1.Elements.Add(row2Column1Element4);
            row2Column1Element4.Type = "button";
            row2Column1Element4.CssClass = "large expand";
            row2Column1Element4.Elements = new List<Element>();

            Element row2Column1Element4SubElement1 = new Element();
            row2Column1Element4SubElement1.Type = "center";
            row2Column1Element4.Elements.Add(row2Column1Element4SubElement1);
            row2Column1Element4SubElement1.Elements = new List<Element>();

            Element row2Column1Element4SubElement1Inner1 = new Element();
            row2Column1Element4SubElement1Inner1.Type = "a";
            row2Column1Element4SubElement1Inner1.Link = "#";
            row2Column1Element4SubElement1Inner1.CssClass = "float-center";
            row2Column1Element4SubElement1Inner1.Value = "Reset Password";
            row2Column1Element4SubElement1.Elements.Add(row2Column1Element4SubElement1Inner1);

            Element row2Column1Element5 = new Element();
            row2Column1.Elements.Add(row2Column1Element5);
            row2Column1Element5.Type = "hr";


            Element row2Column1Element6 = new Element();
            row2Column1.Elements.Add(row2Column1Element6);
            row2Column1Element6.Type = "p";
            row2Column1Element6.Elements = new List<Element>();

            Element row2Column1Element6SubElement1 = new Element();
            row2Column1Element6SubElement1.Type = "small";
            row2Column1Element6SubElement1.Value = "You're getting this email because you've signed up for email updates. If you want to opt-out of future emails, ";
            row2Column1Element6.Elements.Add(row2Column1Element6SubElement1);
            row2Column1Element6SubElement1.Elements = new List<Element>();


            Element row2Column1Element6SubElement1Inner1 = new Element();
            row2Column1Element6SubElement1Inner1.Type = "a";
            row2Column1Element6SubElement1Inner1.Link = "#";
            row2Column1Element6SubElement1Inner1.Value = "unsubscribe here";
            row2Column1Element6SubElement1Inner1.Property = "align";
            row2Column1Element6SubElement1Inner1.Style = "this-is-testing-style";
            row2Column1Element6SubElement1Inner1.PropertyValue = "center";
            row2Column1Element6SubElement1.Elements.Add(row2Column1Element6SubElement1Inner1);


            var json = JsonConvert.SerializeObject(jsonStructure);

            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("body", "<table class=\"body\"><tr><td align=\"center\" class=\"center\" valign=\"top\"><center data-parsed=\"\">");
            values.Add("container", "<table class=\"container\"><tbody><tr><td>");
            values.Add("row", "<table class=\"row\"><tbody><tr>");
            values.Add("column", "<th><table><tr><td>");
            values.Add("table", "<table><tbody><tr>");
            values.Add("img", "<img src=\"\">");
            values.Add("callout", "<table class=\"callout\"><tr>");
            values.Add("callout-inner", "<th class=\"callout-inner\">");
            values.Add("menu", "<table class=\"menu\"><tbody><tr><td><table><tbody><tr>");
            values.Add("menu-item", "<th class=\"menu-item\">");
            values.Add("a", "<a href=\"\">");
            values.Add("button", "<table class=\"button\"><tbody><tr><td><table><tbody><tr><td>");
            values.Add("wrapper", "<table class=\"wrapper\"><tbody><tr>");
            values.Add("wrapper-inner", "<td class=\"wrapper-inner\">");
            values.Add("spacer", "<table class=\"spacer\"><tbody><tr>");
            values.Add("spacerHeight", "<td style=\"font-size:16px;line-height:16px;\">");
            values.Add("center", "<center data-parsed=\"\">");


            values.Add("/body", "</center></td></tr></table>");
            values.Add("/container", "</td></tr></tbody></table>");
            values.Add("/row", "</tr></tbody></table>");
            values.Add("/column", "</td></tr></table></th>");
            values.Add("/table", "</tr></tbody></table>");
            values.Add("/img", "");
            values.Add("/callout", "</tr></table>");
            values.Add("/callout-inner", "</th>");
            values.Add("/menu", "</tr></tbody></table></td></tr></tbody></table>");
            values.Add("/menu-item", "</th>");
            values.Add("/a", "</a>");
            values.Add("/button", "</td></tr></tbody></table></td></tr></tbody></table>");
            values.Add("/wrapper", "</tr></tbody></table>");
            values.Add("/wrapper-inner", "</td>");
            values.Add("/spacer", "</tr></tbody></table>");
            values.Add("/spacerHeight", "</td>");
            values.Add("/center", "</center>");
            Stack stack = new Stack();
            Stack stackValue = new Stack();

            Dictionary<string, string> listOfTagsWhichAreEmbedded = new Dictionary<string, string>();

            listOfTagsWhichAreEmbedded.Add("cssclass", "class");
            listOfTagsWhichAreEmbedded.Add("imageUrl", "src");
            listOfTagsWhichAreEmbedded.Add("link", "href");
            listOfTagsWhichAreEmbedded.Add("property", "propertyValue");
            listOfTagsWhichAreEmbedded.Add("style", "style");

            var finalOutputString = "";
            var finalString = renderingFunction(jsonStructure.Section, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
            return finalString;
        }
        public async Task<InlineResult> FinalHtml(string tabularHtml)
        {
            string htmlSource = "<html style=\"min-height: 100%;background: #f3f3f3 !important\"><head>    <meta http-equiv=\"content-type\" content=\"text/html; charset=iso-8859-1\">    <style class=\"float-center\" type=\"text/css\">        .wrapper {            width: 100%;        }        #outlook a {            padding: 0;        }        body {            width: 100% !important;            min-width: 100%;            -webkit-text-size-adjust: 100%;            -ms-text-size-adjust: 100%;            margin: 0;            Margin: 0;            padding: 0;            -moz-box-sizing: border-box;            -webkit-box-sizing: border-box;            box-sizing: border-box;        }        .ExternalClass {            width: 100%;        }        .ExternalClass,        .ExternalClass p,        .ExternalClass span,        .ExternalClass font,        .ExternalClass td,        .ExternalClass div {            line-height: 100%;        }        #backgroundTable {            margin: 0;            Margin: 0;            padding: 0;            width: 100% !important;            line-height: 100% !important;        }        img {            outline: none;            text-decoration: none;            -ms-interpolation-mode: bicubic;            width: auto;            max-width: 100%;            clear: both;            display: block;        }        center {            width: 100%;            min-width: 580px;        }        a img {            border: none;        }        p {            margin: 0 0 0 10px;            Margin: 0 0 0 10px;        }        table {            border-spacing: 0;            border-collapse: collapse;        }        td {            word-wrap: break-word;            -webkit-hyphens: auto;            -moz-hyphens: auto;            hyphens: auto;            border-collapse: collapse !important;        }        table,        tr,        td {            padding: 0;            vertical-align: top;            text-align: left;        }        @media only screen {            html {                min-height: 100%;                background: #f3f3f3;            }        }        table.body {            background: #f3f3f3;            height: 100%;            width: 100%;        }        table.container {            background: #fefefe;            width: 580px;            margin: 0 auto;            Margin: 0 auto;            text-align: inherit;        }        table.row {            padding: 0;            width: 100%;            position: relative;        }        table.spacer {            width: 100%;        }        table.spacer td {            mso-line-height-rule: exactly;        }        table.container table.row {            display: table;        }        td.columns,        td.column,        th.columns,        th.column {            margin: 0 auto;            Margin: 0 auto;            padding-left: 16px;            padding-bottom: 16px;        }        td.columns .column,        td.columns .columns,        td.column .column,        td.column .columns,        th.columns .column,        th.columns .columns,        th.column .column,        th.column .columns {            padding-left: 0 !important;            padding-right: 0 !important;        }        td.columns .column center,        td.columns .columns center,        td.column .column center,        td.column .columns center,        th.columns .column center,        th.columns .columns center,        th.column .column center,        th.column .columns center {            min-width: none !important;        }        td.columns.last,        td.column.last,        th.columns.last,        th.column.last {            padding-right: 16px;        }        td.columns table:not(.button),        td.column table:not(.button),        th.columns table:not(.button),        th.column table:not(.button) {            width: 100%;        }        td.large-1,        th.large-1 {            width: 32.33333px;            padding-left: 8px;            padding-right: 8px;        }        td.large-1.first,        th.large-1.first {            padding-left: 16px;        }        td.large-1.last,        th.large-1.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-1,        .collapse>tbody>tr>th.large-1 {            padding-right: 0;            padding-left: 0;            width: 48.33333px;        }        .collapse td.large-1.first,        .collapse th.large-1.first,        .collapse td.large-1.last,        .collapse th.large-1.last {            width: 56.33333px;        }        td.large-1 center,        th.large-1 center {            min-width: 0.33333px;        }        .body .columns td.large-1,        .body .column td.large-1,        .body .columns th.large-1,        .body .column th.large-1 {            width: 8.33333%;        }        td.large-2,        th.large-2 {            width: 80.66667px;            padding-left: 8px;            padding-right: 8px;        }        td.large-2.first,        th.large-2.first {            padding-left: 16px;        }        td.large-2.last,        th.large-2.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-2,        .collapse>tbody>tr>th.large-2 {            padding-right: 0;            padding-left: 0;            width: 96.66667px;        }        .collapse td.large-2.first,        .collapse th.large-2.first,        .collapse td.large-2.last,        .collapse th.large-2.last {            width: 104.66667px;        }        td.large-2 center,        th.large-2 center {            min-width: 48.66667px;        }        .body .columns td.large-2,        .body .column td.large-2,        .body .columns th.large-2,        .body .column th.large-2 {            width: 16.66667%;        }        td.large-3,        th.large-3 {            width: 129px;            padding-left: 8px;            padding-right: 8px;        }        td.large-3.first,        th.large-3.first {            padding-left: 16px;        }        td.large-3.last,        th.large-3.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-3,        .collapse>tbody>tr>th.large-3 {            padding-right: 0;            padding-left: 0;            width: 145px;        }        .collapse td.large-3.first,        .collapse th.large-3.first,        .collapse td.large-3.last,        .collapse th.large-3.last {            width: 153px;        }        td.large-3 center,        th.large-3 center {            min-width: 97px;        }        .body .columns td.large-3,        .body .column td.large-3,        .body .columns th.large-3,        .body .column th.large-3 {            width: 25%;        }        td.large-4,        th.large-4 {            width: 177.33333px;            padding-left: 8px;            padding-right: 8px;        }        td.large-4.first,        th.large-4.first {            padding-left: 16px;        }        td.large-4.last,        th.large-4.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-4,        .collapse>tbody>tr>th.large-4 {            padding-right: 0;            padding-left: 0;            width: 193.33333px;        }        .collapse td.large-4.first,        .collapse th.large-4.first,        .collapse td.large-4.last,        .collapse th.large-4.last {            width: 201.33333px;        }        td.large-4 center,        th.large-4 center {            min-width: 145.33333px;        }        .body .columns td.large-4,        .body .column td.large-4,        .body .columns th.large-4,        .body .column th.large-4 {            width: 33.33333%;        }        td.large-5,        th.large-5 {            width: 225.66667px;            padding-left: 8px;            padding-right: 8px;        }        td.large-5.first,        th.large-5.first {            padding-left: 16px;        }        td.large-5.last,        th.large-5.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-5,        .collapse>tbody>tr>th.large-5 {            padding-right: 0;            padding-left: 0;            width: 241.66667px;        }        .collapse td.large-5.first,        .collapse th.large-5.first,        .collapse td.large-5.last,        .collapse th.large-5.last {            width: 249.66667px;        }        td.large-5 center,        th.large-5 center {            min-width: 193.66667px;        }        .body .columns td.large-5,        .body .column td.large-5,        .body .columns th.large-5,        .body .column th.large-5 {            width: 41.66667%;        }        td.large-6,        th.large-6 {            width: 274px;            padding-left: 8px;            padding-right: 8px;        }        td.large-6.first,        th.large-6.first {            padding-left: 16px;        }        td.large-6.last,        th.large-6.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-6,        .collapse>tbody>tr>th.large-6 {            padding-right: 0;            padding-left: 0;            width: 290px;        }        .collapse td.large-6.first,        .collapse th.large-6.first,        .collapse td.large-6.last,        .collapse th.large-6.last {            width: 298px;        }        td.large-6 center,        th.large-6 center {            min-width: 242px;        }        .body .columns td.large-6,        .body .column td.large-6,        .body .columns th.large-6,        .body .column th.large-6 {            width: 50%;        }        td.large-7,        th.large-7 {            width: 322.33333px;            padding-left: 8px;            padding-right: 8px;        }        td.large-7.first,        th.large-7.first {            padding-left: 16px;        }        td.large-7.last,        th.large-7.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-7,        .collapse>tbody>tr>th.large-7 {            padding-right: 0;            padding-left: 0;            width: 338.33333px;        }        .collapse td.large-7.first,        .collapse th.large-7.first,        .collapse td.large-7.last,        .collapse th.large-7.last {            width: 346.33333px;        }        td.large-7 center,        th.large-7 center {            min-width: 290.33333px;        }        .body .columns td.large-7,        .body .column td.large-7,        .body .columns th.large-7,        .body .column th.large-7 {            width: 58.33333%;        }        td.large-8,        th.large-8 {            width: 370.66667px;            padding-left: 8px;            padding-right: 8px;        }        td.large-8.first,        th.large-8.first {            padding-left: 16px;        }        td.large-8.last,        th.large-8.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-8,        .collapse>tbody>tr>th.large-8 {            padding-right: 0;            padding-left: 0;            width: 386.66667px;        }        .collapse td.large-8.first,        .collapse th.large-8.first,        .collapse td.large-8.last,        .collapse th.large-8.last {            width: 394.66667px;        }        td.large-8 center,        th.large-8 center {            min-width: 338.66667px;        }        .body .columns td.large-8,        .body .column td.large-8,        .body .columns th.large-8,        .body .column th.large-8 {            width: 66.66667%;        }        td.large-9,        th.large-9 {            width: 419px;            padding-left: 8px;            padding-right: 8px;        }        td.large-9.first,        th.large-9.first {            padding-left: 16px;        }        td.large-9.last,        th.large-9.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-9,        .collapse>tbody>tr>th.large-9 {            padding-right: 0;            padding-left: 0;            width: 435px;        }        .collapse td.large-9.first,        .collapse th.large-9.first,        .collapse td.large-9.last,        .collapse th.large-9.last {            width: 443px;        }        td.large-9 center,        th.large-9 center {            min-width: 387px;        }        .body .columns td.large-9,        .body .column td.large-9,        .body .columns th.large-9,        .body .column th.large-9 {            width: 75%;        }        td.large-10,        th.large-10 {            width: 467.33333px;            padding-left: 8px;            padding-right: 8px;        }        td.large-10.first,        th.large-10.first {            padding-left: 16px;        }        td.large-10.last,        th.large-10.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-10,        .collapse>tbody>tr>th.large-10 {            padding-right: 0;            padding-left: 0;            width: 483.33333px;        }        .collapse td.large-10.first,        .collapse th.large-10.first,        .collapse td.large-10.last,        .collapse th.large-10.last {            width: 491.33333px;        }        td.large-10 center,        th.large-10 center {            min-width: 435.33333px;        }        .body .columns td.large-10,        .body .column td.large-10,        .body .columns th.large-10,        .body .column th.large-10 {            width: 83.33333%;        }        td.large-11,        th.large-11 {            width: 515.66667px;            padding-left: 8px;            padding-right: 8px;        }        td.large-11.first,        th.large-11.first {            padding-left: 16px;        }        td.large-11.last,        th.large-11.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-11,        .collapse>tbody>tr>th.large-11 {            padding-right: 0;            padding-left: 0;            width: 531.66667px;        }        .collapse td.large-11.first,        .collapse th.large-11.first,        .collapse td.large-11.last,        .collapse th.large-11.last {            width: 539.66667px;        }        td.large-11 center,        th.large-11 center {            min-width: 483.66667px;        }        .body .columns td.large-11,        .body .column td.large-11,        .body .columns th.large-11,        .body .column th.large-11 {            width: 91.66667%;        }        td.large-12,        th.large-12 {            width: 564px;            padding-left: 8px;            padding-right: 8px;        }        td.large-12.first,        th.large-12.first {            padding-left: 16px;        }        td.large-12.last,        th.large-12.last {            padding-right: 16px;        }        .collapse>tbody>tr>td.large-12,        .collapse>tbody>tr>th.large-12 {            padding-right: 0;            padding-left: 0;            width: 580px;        }        .collapse td.large-12.first,        .collapse th.large-12.first,        .collapse td.large-12.last,        .collapse th.large-12.last {            width: 588px;        }        td.large-12 center,        th.large-12 center {            min-width: 532px;        }        .body .columns td.large-12,        .body .column td.large-12,        .body .columns th.large-12,        .body .column th.large-12 {            width: 100%;        }        td.large-offset-1,        td.large-offset-1.first,        td.large-offset-1.last,        th.large-offset-1,        th.large-offset-1.first,        th.large-offset-1.last {            padding-left: 64.33333px;        }        td.large-offset-2,        td.large-offset-2.first,        td.large-offset-2.last,        th.large-offset-2,        th.large-offset-2.first,        th.large-offset-2.last {            padding-left: 112.66667px;        }        td.large-offset-3,        td.large-offset-3.first,        td.large-offset-3.last,        th.large-offset-3,        th.large-offset-3.first,        th.large-offset-3.last {            padding-left: 161px;        }        td.large-offset-4,        td.large-offset-4.first,        td.large-offset-4.last,        th.large-offset-4,        th.large-offset-4.first,        th.large-offset-4.last {            padding-left: 209.33333px;        }        td.large-offset-5,        td.large-offset-5.first,        td.large-offset-5.last,        th.large-offset-5,        th.large-offset-5.first,        th.large-offset-5.last {            padding-left: 257.66667px;        }        td.large-offset-6,        td.large-offset-6.first,        td.large-offset-6.last,        th.large-offset-6,        th.large-offset-6.first,        th.large-offset-6.last {            padding-left: 306px;        }        td.large-offset-7,        td.large-offset-7.first,        td.large-offset-7.last,        th.large-offset-7,        th.large-offset-7.first,        th.large-offset-7.last {            padding-left: 354.33333px;        }        td.large-offset-8,        td.large-offset-8.first,        td.large-offset-8.last,        th.large-offset-8,        th.large-offset-8.first,        th.large-offset-8.last {            padding-left: 402.66667px;        }        td.large-offset-9,        td.large-offset-9.first,        td.large-offset-9.last,        th.large-offset-9,        th.large-offset-9.first,        th.large-offset-9.last {            padding-left: 451px;        }        td.large-offset-10,        td.large-offset-10.first,        td.large-offset-10.last,        th.large-offset-10,        th.large-offset-10.first,        th.large-offset-10.last {            padding-left: 499.33333px;        }        td.large-offset-11,        td.large-offset-11.first,        td.large-offset-11.last,        th.large-offset-11,        th.large-offset-11.first,        th.large-offset-11.last {            padding-left: 547.66667px;        }        td.expander,        th.expander {            visibility: hidden;            width: 0;            padding: 0 !important;        }        table.container.radius {            border-radius: 0;            border-collapse: separate;        }        .block-grid {            width: 100%;            max-width: 580px;        }        .block-grid td {            display: inline-block;            padding: 8px;        }        .up-2 td {            width: 274px !important;        }        .up-3 td {            width: 177px !important;        }        .up-4 td {            width: 129px !important;        }        .up-5 td {            width: 100px !important;        }        .up-6 td {            width: 80px !important;        }        .up-7 td {            width: 66px !important;        }        .up-8 td {            width: 56px !important;        }        table.text-center,        th.text-center,        td.text-center,        h1.text-center,        h2.text-center,        h3.text-center,        h4.text-center,        h5.text-center,        h6.text-center,        p.text-center,        span.text-center {            text-align: center;        }        table.text-left,        th.text-left,        td.text-left,        h1.text-left,        h2.text-left,        h3.text-left,        h4.text-left,        h5.text-left,        h6.text-left,        p.text-left,        span.text-left {            text-align: left;        }        table.text-right,        th.text-right,        td.text-right,        h1.text-right,        h2.text-right,        h3.text-right,        h4.text-right,        h5.text-right,        h6.text-right,        p.text-right,        span.text-right {            text-align: right;        }        span.text-center {            display: block;            width: 100%;            text-align: center;        }        @media only screen and (max-width: 596px) {            .small-float-center {                margin: 0 auto !important;                float: none !important;                text-align: center !important;            }            .small-text-center {                text-align: center !important;            }            .small-text-left {                text-align: left !important;            }            .small-text-right {                text-align: right !important;            }        }        img.float-left {            float: left;            text-align: left;        }        img.float-right {            float: right;            text-align: right;        }        img.float-center,        img.text-center {            margin: 0 auto;            Margin: 0 auto;            float: none;            text-align: center;        }        table.float-center,        td.float-center,        th.float-center {            margin: 0 auto;            Margin: 0 auto;            float: none;            text-align: center;        }        .hide-for-large {            display: none !important;            mso-hide: all;            overflow: hidden;            max-height: 0;            font-size: 0;            width: 0;            line-height: 0;        }        @media only screen and (max-width: 596px) {            .hide-for-large {                display: block !important;                width: auto !important;                overflow: visible !important;                max-height: none !important;                font-size: inherit !important;                line-height: inherit !important;            }        }        table.body table.container .hide-for-large * {            mso-hide: all;        }        @media only screen and (max-width: 596px) {            table.body table.container .hide-for-large,            table.body table.container .row.hide-for-large {                display: table !important;                width: 100% !important;            }        }        @media only screen and (max-width: 596px) {            table.body table.container .callout-inner.hide-for-large {                display: table-cell !important;                width: 100% !important;            }        }        @media only screen and (max-width: 596px) {            table.body table.container .show-for-large {                display: none !important;                width: 0;                mso-hide: all;                overflow: hidden;            }        }        body,        table.body,        h1,        h2,        h3,        h4,        h5,        h6,        p,        td,        th,        a {            color: #0a0a0a;            font-family: Helvetica, Arial, sans-serif;            font-weight: normal;            padding: 0;            margin: 0;            Margin: 0;            text-align: left;            line-height: 1.3;        }        h1,        h2,        h3,        h4,        h5,        h6 {            color: inherit;            word-wrap: normal;            font-family: Helvetica, Arial, sans-serif;            font-weight: normal;            margin-bottom: 10px;            Margin-bottom: 10px;        }        h1 {            font-size: 34px;        }        h2 {            font-size: 30px;        }        h3 {            font-size: 28px;        }        h4 {            font-size: 24px;        }        h5 {            font-size: 20px;        }        h6 {            font-size: 18px;        }        body,        table.body,        p,        td,        th {            font-size: 16px;            line-height: 1.3;        }        p {            margin-bottom: 10px;            Margin-bottom: 10px;        }        p.lead {            font-size: 20px;            line-height: 1.6;        }        p.subheader {            margin-top: 4px;            margin-bottom: 8px;            Margin-top: 4px;            Margin-bottom: 8px;            font-weight: normal;            line-height: 1.4;            color: #8a8a8a;        }        small {            font-size: 80%;            color: #cacaca;        }        a {            color: #2199e8;            text-decoration: none;        }        a:hover {            color: #147dc2;        }        a:active {            color: #147dc2;        }        a:visited {            color: #2199e8;        }        h1 a,        h1 a:visited,        h2 a,        h2 a:visited,        h3 a,        h3 a:visited,        h4 a,        h4 a:visited,        h5 a,        h5 a:visited,        h6 a,        h6 a:visited {            color: #2199e8;        }        pre {            background: #f3f3f3;            margin: 30px 0;            Margin: 30px 0;        }        pre code {            color: #cacaca;        }        pre code span.callout {            color: #8a8a8a;            font-weight: bold;        }        pre code span.callout-strong {            color: #ff6908;            font-weight: bold;        }        table.hr {            width: 100%;        }        table.hr th {            height: 0;            max-width: 580px;            border-top: 0;            border-right: 0;            border-bottom: 1px solid #0a0a0a;            border-left: 0;            margin: 20px auto;            Margin: 20px auto;            clear: both;        }        .stat {            font-size: 40px;            line-height: 1;        }        p+.stat {            margin-top: -16px;            Margin-top: -16px;        }        span.preheader {            display: none !important;            visibility: hidden;            mso-hide: all !important;            font-size: 1px;            color: #f3f3f3;            line-height: 1px;            max-height: 0px;            max-width: 0px;            opacity: 0;            overflow: hidden;        }        table.button {            width: auto;            margin: 0 0 16px 0;            Margin: 0 0 16px 0;        }        table.button table td {            text-align: left;            color: #fefefe;            background: #2199e8;            border: 2px solid #2199e8;        }        table.button table td a {            font-family: Helvetica, Arial, sans-serif;            font-size: 16px;            font-weight: bold;            color: #fefefe;            text-decoration: none;            display: inline-block;            padding: 8px 16px 8px 16px;            border: 0 solid #2199e8;            border-radius: 3px;        }        table.button.radius table td {            border-radius: 3px;            border: none;        }        table.button.rounded table td {            border-radius: 500px;            border: none;        }        table.button:hover table tr td a,        table.button:active table tr td a,        table.button table tr td a:visited,        table.button.tiny:hover table tr td a,        table.button.tiny:active table tr td a,        table.button.tiny table tr td a:visited,        table.button.small:hover table tr td a,        table.button.small:active table tr td a,        table.button.small table tr td a:visited,        table.button.large:hover table tr td a,        table.button.large:active table tr td a,        table.button.large table tr td a:visited {            color: #fefefe;        }        table.button.tiny table td,        table.button.tiny table a {            padding: 4px 8px 4px 8px;        }        table.button.tiny table a {            font-size: 10px;            font-weight: normal;        }        table.button.small table td,        table.button.small table a {            padding: 5px 10px 5px 10px;            font-size: 12px;        }        table.button.large table a {            padding: 10px 20px 10px 20px;            font-size: 20px;        }        table.button.expand,        table.button.expanded {            width: 100% !important;        }        table.button.expand table,        table.button.expanded table {            width: 100%;        }        table.button.expand table a,        table.button.expanded table a {            text-align: center;            width: 100%;            padding-left: 0;            padding-right: 0;        }        table.button.expand center,        table.button.expanded center {            min-width: 0;        }        table.button:hover table td,        table.button:visited table td,        table.button:active table td {            background: #147dc2;            color: #fefefe;        }        table.button:hover table a,        table.button:visited table a,        table.button:active table a {            border: 0 solid #147dc2;        }        table.button.secondary table td {            background: #777777;            color: #fefefe;            border: 0px solid #777777;        }        table.button.secondary table a {            color: #fefefe;            border: 0 solid #777777;        }        table.button.secondary:hover table td {            background: #919191;            color: #fefefe;        }        table.button.secondary:hover table a {            border: 0 solid #919191;        }        table.button.secondary:hover table td a {            color: #fefefe;        }        table.button.secondary:active table td a {            color: #fefefe;        }        table.button.secondary table td a:visited {            color: #fefefe;        }        table.button.success table td {            background: #3adb76;            border: 0px solid #3adb76;        }        table.button.success table a {            border: 0 solid #3adb76;        }        table.button.success:hover table td {            background: #23bf5d;        }        table.button.success:hover table a {            border: 0 solid #23bf5d;        }        table.button.alert table td {            background: #ec5840;            border: 0px solid #ec5840;        }        table.button.alert table a {            border: 0 solid #ec5840;        }        table.button.alert:hover table td {            background: #e23317;        }        table.button.alert:hover table a {            border: 0 solid #e23317;        }        table.button.warning table td {            background: #ffae00;            border: 0px solid #ffae00;        }        table.button.warning table a {            border: 0px solid #ffae00;        }        table.button.warning:hover table td {            background: #cc8b00;        }        table.button.warning:hover table a {            border: 0px solid #cc8b00;        }        table.callout {            margin-bottom: 16px;            Margin-bottom: 16px;        }        th.callout-inner {            width: 100%;            border: 1px solid #cbcbcb;            padding: 10px;            background: #fefefe;        }        th.callout-inner.primary {            background: #def0fc;            border: 1px solid #444444;            color: #0a0a0a;        }        th.callout-inner.secondary {            background: #ebebeb;            border: 1px solid #444444;            color: #0a0a0a;        }        th.callout-inner.success {            background: #e1faea;            border: 1px solid #1b9448;            color: #fefefe;        }        th.callout-inner.warning {            background: #fff3d9;            border: 1px solid #996800;            color: #fefefe;        }        th.callout-inner.alert {            background: #fce6e2;            border: 1px solid #b42912;            color: #fefefe;        }        .thumbnail {            border: solid 4px #fefefe;            box-shadow: 0 0 0 1px rgba(10, 10, 10, 0.2);            display: inline-block;            line-height: 0;            max-width: 100%;            transition: box-shadow 200ms ease-out;            border-radius: 3px;            margin-bottom: 16px;        }        .thumbnail:hover,        .thumbnail:focus {            box-shadow: 0 0 6px 1px rgba(33, 153, 232, 0.5);        }        table.menu {            width: 580px;        }        table.menu td.menu-item,        table.menu th.menu-item {            padding: 10px;            padding-right: 10px;        }        table.menu td.menu-item a,        table.menu th.menu-item a {            color: #2199e8;        }        table.menu.vertical td.menu-item,        table.menu.vertical th.menu-item {            padding: 10px;            padding-right: 0;            display: block;        }        table.menu.vertical td.menu-item a,        table.menu.vertical th.menu-item a {            width: 100%;        }        table.menu.vertical td.menu-item table.menu.vertical td.menu-item,        table.menu.vertical td.menu-item table.menu.vertical th.menu-item,        table.menu.vertical th.menu-item table.menu.vertical td.menu-item,        table.menu.vertical th.menu-item table.menu.vertical th.menu-item {            padding-left: 10px;        }        table.menu.text-center a {            text-align: center;        }        .menu[align='center'] {            width: auto !important;        }        body.outlook p {            display: inline !important;        }        @media only screen and (max-width: 596px) {            table.body img {                width: auto;                height: auto;            }            table.body center {                min-width: 0 !important;            }            table.body .container {                width: 95% !important;            }            table.body .columns,            table.body .column {                height: auto !important;                -moz-box-sizing: border-box;                -webkit-box-sizing: border-box;                box-sizing: border-box;                padding-left: 16px !important;                padding-right: 16px !important;            }            table.body .columns .column,            table.body .columns .columns,            table.body .column .column,            table.body .column .columns {                padding-left: 0 !important;                padding-right: 0 !important;            }            table.body .collapse .columns,            table.body .collapse .column {                padding-left: 0 !important;                padding-right: 0 !important;            }            td.small-1,            th.small-1 {                display: inline-block !important;                width: 8.33333% !important;            }            td.small-2,            th.small-2 {                display: inline-block !important;                width: 16.66667% !important;            }            td.small-3,            th.small-3 {                display: inline-block !important;                width: 25% !important;            }            td.small-4,            th.small-4 {                display: inline-block !important;                width: 33.33333% !important;            }            td.small-5,            th.small-5 {                display: inline-block !important;                width: 41.66667% !important;            }            td.small-6,            th.small-6 {                display: inline-block !important;                width: 50% !important;            }            td.small-7,            th.small-7 {                display: inline-block !important;                width: 58.33333% !important;            }            td.small-8,            th.small-8 {                display: inline-block !important;                width: 66.66667% !important;            }            td.small-9,            th.small-9 {                display: inline-block !important;                width: 75% !important;            }            td.small-10,            th.small-10 {                display: inline-block !important;                width: 83.33333% !important;            }            td.small-11,            th.small-11 {                display: inline-block !important;                width: 91.66667% !important;            }            td.small-12,            th.small-12 {                display: inline-block !important;                width: 100% !important;            }            .columns td.small-12,            .column td.small-12,            .columns th.small-12,            .column th.small-12 {                display: block !important;                width: 100% !important;            }            table.body td.small-offset-1,            table.body th.small-offset-1 {                margin-left: 8.33333% !important;                Margin-left: 8.33333% !important;            }            table.body td.small-offset-2,            table.body th.small-offset-2 {                margin-left: 16.66667% !important;                Margin-left: 16.66667% !important;            }            table.body td.small-offset-3,            table.body th.small-offset-3 {                margin-left: 25% !important;                Margin-left: 25% !important;            }            table.body td.small-offset-4,            table.body th.small-offset-4 {                margin-left: 33.33333% !important;                Margin-left: 33.33333% !important;            }            table.body td.small-offset-5,            table.body th.small-offset-5 {                margin-left: 41.66667% !important;                Margin-left: 41.66667% !important;            }            table.body td.small-offset-6,            table.body th.small-offset-6 {                margin-left: 50% !important;                Margin-left: 50% !important;            }            table.body td.small-offset-7,            table.body th.small-offset-7 {                margin-left: 58.33333% !important;                Margin-left: 58.33333% !important;            }            table.body td.small-offset-8,            table.body th.small-offset-8 {                margin-left: 66.66667% !important;                Margin-left: 66.66667% !important;            }            table.body td.small-offset-9,            table.body th.small-offset-9 {                margin-left: 75% !important;                Margin-left: 75% !important;            }            table.body td.small-offset-10,            table.body th.small-offset-10 {                margin-left: 83.33333% !important;                Margin-left: 83.33333% !important;            }            table.body td.small-offset-11,            table.body th.small-offset-11 {                margin-left: 91.66667% !important;                Margin-left: 91.66667% !important;            }            table.body table.columns td.expander,            table.body table.columns th.expander {                display: none !important;            }            table.body .right-text-pad,            table.body .text-pad-right {                padding-left: 10px !important;            }            table.body .left-text-pad,            table.body .text-pad-left {                padding-right: 10px !important;            }            table.menu {                width: 100% !important;            }            table.menu td,            table.menu th {                width: auto !important;                display: inline-block !important;            }            table.menu.vertical td,            table.menu.vertical th,            table.menu.small-vertical td,            table.menu.small-vertical th {                display: block !important;            }            table.menu[align='center'] {                width: auto !important;            }            table.button.small-expand,            table.button.small-expanded {                width: 100% !important;            }            table.button.small-expand table,            table.button.small-expanded table {                width: 100%;            }            table.button.small-expand table a,            table.button.small-expanded table a {                text-align: center !important;                width: 100% !important;                padding-left: 0 !important;                padding-right: 0 !important;            }            table.button.small-expand center,            table.button.small-expanded center {                min-width: 0;            }        }        body,        html,        .body {            background: #f3f3f3 !important;        }        .header {            background: #f3f3f3;        }    </style></head><body>";
            htmlSource = htmlSource + tabularHtml + "</body></html>";
            var value = PreMailer.Net.PreMailer.MoveCssInline(htmlSource);
            return value;
        }
        public async Task<EngineResponse> SendEmail(InlineResult value,string SenderEmail)
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFromAddress = "arjungargtesting@gmail.com";
            string password = "mnbvcxz5@";
            string emailToAddress = SenderEmail;
            string subject = "Testing Template From Arjun Garg";
            string body = value.Html;
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(emailToAddress);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
            catch(Exception ex)
            {
                EngineResponse engineResponse = new EngineResponse();
                engineResponse.EmailSent = false;
                return engineResponse;
            }
            EngineResponse engineResponse1 = new EngineResponse();
            engineResponse1.EmailSent = true;
            return engineResponse1;
        }
        public static string appendCustomProperty(string propertyName, string propertyValue, string finalstring)
        {

            if (string.IsNullOrEmpty(finalstring))
            {
                return "";
            }
            int counter = 1;
            var anss = getMeNameOfTags(finalstring.Substring(counter));
            counter = counter + anss.Length;

            finalstring = finalstring.Insert(counter, " " + propertyName + "=" + "\"" + propertyValue + "\"");

            return finalstring;
        }
        public static string appendTags(string valueOfTag, string finalstring, string nameOfTag)
        {
            if (string.IsNullOrEmpty(finalstring))
            {
                return "";
            }
            int counter = 1;
            var anss = getMeNameOfTags(finalstring.Substring(counter));
            counter = counter + anss.Length;
            if (anss.Contains(nameOfTag))
            {
                string[] tempArrayOfString = new string[] { "" };
                tempArrayOfString = anss.Split(" ");
                var finalValueToReplace = "";
                foreach (var value in tempArrayOfString)
                {
                    if (value.Contains(nameOfTag))
                    {
                        var finalValueAftterInsertionOfCss = "";
                        if (nameOfTag == "class")
                        {
                            finalValueAftterInsertionOfCss = value.Insert(value.Length - 1, " " + valueOfTag);
                        }
                        else
                        {
                            finalValueAftterInsertionOfCss = value.Insert(value.Length - 1, valueOfTag);
                        }
                        finalValueToReplace = anss.Replace(value, finalValueAftterInsertionOfCss);
                        break;
                    }
                }
                finalstring = finalstring.Replace(anss, finalValueToReplace);
            }
            else
            {
                finalstring = finalstring.Insert(counter, " " + nameOfTag + "=\"" + valueOfTag + "\"");
            }
            return finalstring;
        }
        public static string getMeNameOfTags(string json)
        {
            if (json[0].Equals('>'))
            {
                return "";
            }
            return json[0] + getMeNameOfTags(json.Substring(1));
        }
        public static string renderingFunction(Section json, string finalOutputString, Dictionary<string, string> values, Stack stack, Stack stackValue, Dictionary<string, string> listOfTagsWhichAreEmbedded)
        {
            if (json == null)
            {
                return finalOutputString;
            }
            if (json != null)
            {
                if (json.Type != null)
                {
                    stack.Push(json.Type);
                    if (json.Property == null && json.Style == null && json.CssClass == null)
                    {
                        if (values.ContainsKey(json.Type))
                        {
                            finalOutputString = finalOutputString + values[json.Type];
                        }
                        else
                        {
                            finalOutputString = finalOutputString + "<" + json.Type + ">";
                        }
                        if (json.Value != null)
                        {
                            finalOutputString = finalOutputString + json.Value;
                        }
                    }
                    else
                    {
                        var valueOfTag = "";
                        if (values.ContainsKey(json.Type))
                        {
                            valueOfTag = values[json.Type];
                        }
                        else
                        {
                            valueOfTag = "<" + json.Type + ">";
                        }
                        if (json.CssClass != null)
                        {
                            valueOfTag = appendTags(json.CssClass, valueOfTag, listOfTagsWhichAreEmbedded["cssclass"]);
                        }
                        if (json.Style != null)
                        {
                            valueOfTag = appendTags(json.Style, valueOfTag, listOfTagsWhichAreEmbedded["style"]);
                        }
                        if (json.Property != null)
                        {
                            valueOfTag = appendCustomProperty(json.Property, json.PropertyValue, valueOfTag);
                        }
                        finalOutputString = finalOutputString + valueOfTag;
                        if (json.Value != null)
                        {
                            finalOutputString = finalOutputString + json.Value;
                        }
                    }
                    if (json.ChildSections != null)
                    {
                        if (json.ChildSections.Count != 0)
                        {
                            foreach (var innerSection in json.ChildSections)
                            {
                                finalOutputString = renderingFunction(innerSection, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
                            }
                        }
                    }
                    if (json.Elements != null && json.Elements.Count != 0)
                    {
                        foreach (var innerSection in json.Elements)
                        {
                            Stack stack1 = new Stack();
                            Stack stackValue1 = new Stack();
                            finalOutputString = finalOutputString + renderingFunctionElement(innerSection, "", values, stack1, stackValue1, listOfTagsWhichAreEmbedded);
                        }
                    }
                    var closeTag = stack.Pop().ToString();
                    if (values.ContainsKey("/" + closeTag))
                    {
                        finalOutputString = finalOutputString + values["/" + closeTag];
                    }
                    else
                    {
                        finalOutputString = finalOutputString + "</" + closeTag + ">";
                    }
                    return finalOutputString;
                }
                renderingFunction(json, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
            }

            return renderingFunction(json, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
        }
        public static string getMeName(string json)
        {
            if (string.IsNullOrEmpty(json) || json[0].Equals('"'))
            {
                return "";
            }
            return json[0] + getMeName(json.Substring(1));
        }
        public static string renderingFunctionElement(Element json, string finalOutputString, Dictionary<string, string> values, Stack stack, Stack stackValue, Dictionary<string, string> listOfTagsWhichAreEmbedded)
        {
            if (json.Type == "small")
            {

            }
            if (json == null)
            {
                return finalOutputString;
            }
            if (json != null)
            {
                if (json.Type != null)
                {
                    stack.Push(json.Type);
                    if (json.Property == null && json.Style == null && json.CssClass == null)
                    {
                        if (values.ContainsKey(json.Type))
                        {
                            finalOutputString = finalOutputString + values[json.Type];
                        }
                        else
                        {
                            finalOutputString = finalOutputString + "<" + json.Type + ">";
                        }
                        if (json.Value != null)
                        {
                            finalOutputString = finalOutputString + json.Value;
                        }
                    }
                    else
                    {
                        var valueOfTag = "";
                        if (values.ContainsKey(json.Type))
                        {
                            valueOfTag = values[json.Type];
                        }
                        else
                        {
                            valueOfTag = "<" + json.Type + ">";
                        }
                        if (json.CssClass != null)
                        {
                            valueOfTag = appendTags(json.CssClass, valueOfTag, listOfTagsWhichAreEmbedded["cssclass"]);
                        }
                        if (json.Style != null)
                        {
                            valueOfTag = appendTags(json.Style, valueOfTag, listOfTagsWhichAreEmbedded["style"]);
                        }
                        if (json.Property != null)
                        {
                            valueOfTag = appendCustomProperty(json.Property, json.PropertyValue, valueOfTag);
                        }
                        if (json.imageUrl != null)
                        {
                            valueOfTag = appendTags(json.imageUrl, valueOfTag, listOfTagsWhichAreEmbedded["imageUrl"]);
                        }
                        if (json.Link != null)
                        {
                            valueOfTag = appendTags(json.Link, valueOfTag, listOfTagsWhichAreEmbedded["link"]);
                        }
                        finalOutputString = finalOutputString + valueOfTag;
                        if (json.Value != null)
                        {
                            finalOutputString = finalOutputString + json.Value;
                        }
                    }

                    if (json.Elements != null)
                    {
                        if (json.Elements.Count != 0)
                        {
                            foreach (var innerSection in json.Elements)
                            {
                                finalOutputString = renderingFunctionElement(innerSection, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
                            }
                        }
                    }
                    var closeTag = stack.Pop().ToString();
                    if (values.ContainsKey("/" + closeTag))
                    {
                        finalOutputString = finalOutputString + values["/" + closeTag];
                    }
                    else
                    {
                        finalOutputString = finalOutputString + "</" + closeTag + ">";
                    }
                    return finalOutputString;
                }
                renderingFunctionElement(json, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
            }

            return renderingFunctionElement(json, finalOutputString, values, stack, stackValue, listOfTagsWhichAreEmbedded);
        }

    }
}
