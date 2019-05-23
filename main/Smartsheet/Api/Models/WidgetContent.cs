﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet.Api.Models
{
    public class WidgetContent
    {
        /// <summary>
        /// Represents the CellLinkWidgetContent object.</summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#celllinkwidgetcontent-object">CellLinkWidge Object Help</seealso>        
        private Hyperlink hyperlink;
        private IList<CellDataItem> cellData;
        private IList<Column> columns;

        /// <summary>
        /// Represents the ChartWidgetContent object. </summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#chartwidgetcontent-object">RichTextWidget Object Help</seealso>        
        private Object axes;
        private Object legend;
        private Object series;

        /// <summary>
        /// Represents the ImageWidgetContent object.</summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#imagewidgetcontent-object">ImageWidgetContent  Object Help</seealso>    
        private string privateId;
        private int? height;
        private int? width;
        private string fileName;
        private string format;

        /// <summary>
        /// Represents the ReportWidgetContent object.</summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#reportwidgetcontent-object">ReportWidgetContent Object Help</seealso>    
        private string htmlContent;

        /// <summary>
        /// Represents the RichTextWidgetContent object.</summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#richtextwidgetcontent-object">RichTextWidget Object Help</seealso>        
        private string html;

        /// <summary>
        /// Represents the ShortcutWidgetContent object.</summary>
        /// <seealso href="http://smartsheet-platform.github.io/api-docs/#shortcutwidgetcontent-object">ShortcutWidgetContent Object Help</seealso>        
        private IList<ShortcutDataItem> shortcutData;

        /// <summary>
        /// Represents the TitleWidgetContent object
        /// </summary>
        private string backgroundColor;

        /// <summary>
        /// Represents the WebContentWidgetContent object
        /// </summary>
        private string url;

        /// <summary>
        /// The widget has when clicked attribute set to that hyperlink (if present and non-null).
        /// </summary>
        /// <returns> the Link </returns>
        public Hyperlink Hyperlink
        {
            get { return hyperlink; }
            set { hyperlink = value; }
        }

        /// <summary>
        /// Array of cellDataItem objects.
        /// </summary>
        /// <returns> the array </returns>
        public IList<CellDataItem> CellData
        {
            get { return cellData; }
            set { cellData = value; }
        }

        /// <summary>
        /// Array of Column objects.
        /// </summary>
        /// <returns> the array </returns>
        public IList<Column> Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        /// <summary>
        /// The widget content as HTML.
        /// </summary>
        /// <returns> the HTML string </returns>
        public string Html
        {
            get { return html; }
            set { html = value; }
        }

        /// <summary>
        /// An array of ShortcutDataItem objects.
        /// </summary>
        /// <returns> the array </returns>
        public IList<ShortcutDataItem> ShortcutData
        {
            get { return shortcutData; }
            set { shortcutData = value; }
        }

        /// <summary>
        /// HTML snippet to render Report.
        /// </summary>
        /// <returns> the HTML string </returns>
        public string HtmlContent
        {
            get { return htmlContent; }
            set { htmlContent = value; }
        }

        /// <summary>
        /// The image private ID.
        /// </summary>
        /// <returns> the ID </returns>
        public string PrivateId
        {
            get { return privateId; }
            set { privateId = value; }
        }

        /// <summary>
        /// Original height of the image in pixels.
        /// </summary>
        /// <returns> the height </returns>
        public int? Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Original width of the image in pixels.
        /// </summary>
        /// <returns> the width </returns>
        public int? Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Name of the image file.
        /// </summary>
        /// <returns> the name </returns>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        /// <summary>
        /// The formatDescriptor for the image file.
        /// </summary>
        /// <returns> the formatDescriptor </returns>
        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        /// <summary>
        /// Gets the background color of a title widget
        /// </summary>
        /// <returns> the background color </returns>
        public string BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        /// <summary>
        /// Gets the axes for a chart widget
        /// </summary>
        /// <returns> the axes </returns>
        public Object Axes
        {
            get { return axes; }
            set { axes = value; }
        }

        /// <summary>
        /// Get the lengend for a chart widget
        /// </summary>
        /// <returns> chart lengend </returns>
        public Object Legend
        {
            get { return legend; }
            set { legend = value; }
        }

        /// <summary>
        /// Get the series data for a chart widget
        /// </summary>
        /// <returns> the series data </returns>
        public Object Series
        {
            get { return series; }
            set { series = value; }
        }

        /// <summary>
        /// Gets the URL for the webContent widget
        /// </summary>
        /// <returns> the url </returns>
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
