#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e7099a55d2a617c0cb189dab4c595c54c5003b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Finance.Pages_FytAdmin_Finance_Report), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Finance/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Finance/Report.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Finance.Pages_FytAdmin_Finance_Report), null)]
namespace FytSoa.Web.Pages.FytAdmin.Finance
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e7099a55d2a617c0cb189dab4c595c54c5003b", @"/Pages/FytAdmin/Finance/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Finance_Report : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Finance\Report.cshtml"
  
    ViewData["Title"] = "财务管理-报表中心";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(151, 898, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        body {
            background-color: #f1f4f5;
        }

        .layui-table td {
            border-radius: 0px;
        }
    </style>
    <div class=""layui-col-md12 list-wall"">
        <div class=""layui-card"">
            <div class=""layui-card-header"">今年数据概览</div>
            <div class=""layui-card-body"">
                <table class=""layui-hide"" id=""tablist""></table>
            </div>
        </div>
    </div>
    <div class=""layui-col-md12 list-wall"">
        <div class=""layui-card"">
            <div class=""layui-card-header"">今年图表概览</div>
            <div class=""layui-card-body"">
                <div id=""base-map"" style=""width: 100%;height:300px;""></div>
            </div>
        </div>
    </div>
    <script type=""text/html"" id=""realMoney"">
        {{(d.realMoney-d.backMoney).toFixed(2)}}
    </script>
    ");
            EndContext();
            BeginContext(1049, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2098612b724e478e1ead74af2f2fff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1122, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1128, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d18eb5698fb46be818a1b87a217b410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1198, 3999, true);
            WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'carousel', 'element'],
            function () {
                var table = layui.table,
                    carousel = layui.carousel;
                table.render({
                    toolbar:true,
                    elem: '#tablist',
                    url: '/api/inventory/monthturnover',
                    cols: [
                        [
                            { field: 'months', width: 100, title: '月份', fixed: 'left' },
                            { field: 'realMoney', width: 150, title: '应收金额' },
                            { field: 'backMoney', width: 150, title: '退货金额'},
                            { field: 'realMoney', width: 150, title: '实收金额', templet: '#realMoney', style: 'background-color: #2F4056; color: #fff;' },
                            { field: 'counts', title: '订单数量' },
                            { field: 'returnCount', title: '返货数' },
                    ");
            WriteLiteral(@"        { field: 'backCount', title: '退货数' }
                        ]
                    ],
                    page: false,
                    id: 'tables',
                    height: 440,
                    done: function (res, curr, count) {
                        baseChart.hideLoading()
                        console.log(res);
                        var datas = [], moneys = [], orderCount = [];
                        for (var i = 0; i < res.data.length; i++) {
                            datas.push(res.data[i].months + '月');
                            moneys.push((res.data[i].realMoney - res.data[i].backMoney).toFixed(2));
                            orderCount.push(res.data[i].counts);
                        }
                        baseChart.setOption({
                            xAxis: {
                                data: datas
                            },
                            series: [{
                                name: '销售金额',
                        ");
            WriteLiteral(@"        type: 'line',
                                stack: '总量',
                                areaStyle: { normal: {} },
                                data: moneys
                            },
                            {
                                name: '订单数',
                                type: 'line',
                                stack: '总量',
                                areaStyle: { normal: {} },
                                data: orderCount
                            }]
                        });
                    }
                });

            });
        var baseChart = echarts.init(document.getElementById('base-map'), 'macarons');
        baseChart.showLoading();
        var option = {
            title: {
                //show:false,
                text: '今年销售金额汇总',
                textStyle: {
                    color: '#888',
                    align: 'center',
                    fontSize: 14,
                    fontWeight: '400'
 ");
            WriteLiteral(@"               }
            },
            tooltip: {
                trigger: 'axis'
            },
            toolbox: {
                feature: {
                    magicType: {
                        type: ['line', 'bar', 'stack', 'tiled']
                    },
                    saveAsImage: {}
                }
            },
            grid: {
                left: '3%',
                right: '4%',
                bottom: '3%',
                containLabel: true
            },
            xAxis: [
                {
                    type: 'category',
                    boundaryGap: false,
                    data: []
                }
            ],
            yAxis: [
                {
                    type: 'value'
                }
            ],
            series: [
            ]
        };
        baseChart.setOption(option);
    </script>
</div>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Finance.ReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Finance.ReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Finance.ReportModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Finance.ReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
