#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d953639bbc13e4f45714a3a3d9575c7fb652ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_TransferGoods), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/TransferGoods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/TransferGoods.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_TransferGoods), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d953639bbc13e4f45714a3a3d9575c7fb652ad", @"/Pages/FytAdmin/Stock/TransferGoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_TransferGoods : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
  
    ViewData["Title"] = "调拨单商品管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 297, true);
            WriteLiteral(@"<div class=""list-wall"">
    <div class=""layui-form list-search"">
        <div class=""layui-inline"">
            <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
        </div>
        <div class=""layui-inline"">
            <select id=""branks"">
                ");
            EndContext();
            BeginContext(455, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1f023f98871488c8e1c6605f45bd052", async() => {
                BeginContext(472, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(492, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                  
                    foreach (var item in Model.codeList)
                    {

#line default
#line hidden
            BeginContext(595, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(619, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad25d675536473a92cdbb1bded80656", async() => {
                BeginContext(647, 9, false);
#line 18 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                                              Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 18 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                           WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(665, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(709, 925, true);
            WriteLiteral(@"            </select>
        </div>
        <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSava""><i class=""layui-icon layui-icon-add-circle-fine""></i> 确定所选商品加入到调拨单</button>
    </div>
    <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
</div>
<script>
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table', 'layer', 'jquery', 'common', 'form'],
        function () {
            var table = layui.table,
                layer = layui.layer,
                $ = layui.jquery,
                os = layui.common,
                form = layui.form;
            form.render('select');
            table.render({
                elem: '#tablist',
                //url: '/api/stock/listbyshopguid?outShopGuid=");
            EndContext();
            BeginContext(1635, 31, false);
#line 41 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                                                         Write(Model.TransferModel.OutShopGuid);

#line default
#line hidden
            EndContext();
            BeginContext(1666, 994, true);
            WriteLiteral(@"
                url: '/api/inventory/stockbyshop',
                cols: [
                    [
                        { type: 'checkbox', fixed: 'left' },
                        { field: 'code',width:180, title: '条形码', sort: true, fixed: 'left' },
                        { field: 'brand', title: '品牌' },
                        { field: 'style', title: '款式' },
                        /*{ field: 'salePrice', title: '价格' },
                        { field: 'disPrice', title: '折扣价' },*/
                        { field: 'stock', title: '库存' },
                        { field: 'goodsSum', width: 120, edit: 'text', title: '<i class=""layui-icon layui-icon-edit""></i>调拨数量', style: 'border-color:#409eff' }
                    ]
                ],
                page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                limit: 10,
                height:515,
                id: 'tables',
                where: {
                    guid:'");
            EndContext();
            BeginContext(2661, 31, false);
#line 60 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                     Write(Model.TransferModel.OutShopGuid);

#line default
#line hidden
            EndContext();
            BeginContext(2692, 143, true);
            WriteLiteral("\'\r\n                }\r\n            });\r\n            var pIndex = parent.layer.getFrameIndex(window.name);     \r\n            var transferGuid = \'");
            EndContext();
            BeginContext(2836, 24, false);
#line 64 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                           Write(Model.TransferModel.Guid);

#line default
#line hidden
            EndContext();
            BeginContext(2860, 14, true);
            WriteLiteral("\',transferSum=");
            EndContext();
            BeginContext(2875, 28, false);
#line 64 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                                                                  Write(Model.TransferModel.GoodsSum);

#line default
#line hidden
            EndContext();
            BeginContext(2903, 2824, true);
            WriteLiteral(@", active = {
                reload: function () {
                    table.reload('tables',
                        {
                            page: {
                                curr: 1
                            },
                            where: {
                                key: $(""#key"").val(),
                                guid: $(""#branks"").val()
                            }
                        });
                },
                toolSearch: function () {
                    active.reload();
                },
                //保存商品到调拨单中
                toolSava: function () {
                    var checkStatus = table.checkStatus('tables')
                        , data = checkStatus.data;
                    if (data.length === 0) {
                        os.error(""请选择要调拨的商品~"");
                        return;
                    }
                    if (transferGuid==='') {
                        os.error(""调拨单为空，请关闭重新选择~"");
                   ");
            WriteLiteral(@"     return;
                    }
                    var isExtNull = false,stockNot=false,stockSum=0;
                    $.each(data, function (i, item) {
                        stockSum += item.goodsSum;
                        //必须输入库存
                        if (!item.goodsSum) {
                            isExtNull = true;
                        } else {
                            //判断是否为数字
                            if (isNaN(item.goodsSum)) {
                                isExtNull = true;
                            }
                            //判断库存是否足够 
                            if (item.stockSum < item.goodsSum) {
                                stockNot = true;
                            }
                            //判断数量不能为0
                            if (item.goodsSum==0) {
                                isExtNull = true;
                            }
                        }
                    });
                    if (stockSum > transferSum) {
    ");
            WriteLiteral(@"                    os.error(""调拨数量不能大于调拨单总数~"");
                        return;
                    }
                    if (isExtNull) {
                        os.error(""调拨数量不能为空，并且必须为数字~~"");
                        return;
                    }
                    if (stockNot) {
                        os.error(""调拨数量不能大于库存数~~"");
                        return;
                    }
                    
                    layer.confirm('确定要执行调拨吗？', function (index) {
                        layer.close(index);
                        var loadindex = layer.load(1, {
                            shade: [0.1, '#000']
                        });
                        os.ajax('api/stock/addtransfergoods/', { TransferGuid: transferGuid, GoodsGuid: '");
            EndContext();
            BeginContext(5728, 15, false);
#line 131 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\TransferGoods.cshtml"
                                                                                                    Write(Model.AdminGuid);

#line default
#line hidden
            EndContext();
            BeginContext(5743, 812, true);
            WriteLiteral(@"', list: data }, function (res) {
                            layer.close(loadindex);
                            if (res.statusCode === 200) {
                                parent.layer.close(pIndex);
                            } else {
                                os.error(res.message);
                            }
                        });
                    });
                }
            };
            $('.list-search .layui-btn').on('click', function () {
                var type = $(this).data('type');
                active[type] ? active[type].call(this) : '';
            });            
        });
</script>
<script type=""text/html"" id=""tool"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.TransferGoodsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.TransferGoodsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.TransferGoodsModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.TransferGoodsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
