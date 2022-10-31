<%@ Page Title="" Language="C#" MasterPageFile="~/ProductInfo.Master" AutoEventWireup="true" CodeBehind="ProductInformation.aspx.cs" Inherits="WebQuanLySanPham.ProductInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="img__productInfo">
                <img src="Assets/client/img__products/img__productInfo--iphone 14.png" alt="" width="370px" height="370px">
            </div>
            <div class="product__information">
                <div class="productInfo__name">APPLE IPHONE 14 PROMAX 256G/VNA </div>
                <p class="productInfo__price">Giá bán: <span style="color: #fd475a; font-weight: bold;">33.990.000₫</span> </p>
                <p class="trademark">Thương hiệu: <a href="apple.com" style="text-decoration: none;">Apple</a></p>
                <p class="status">Tình trạng: Còn hàng</p>
                <p class="description"><span style="font-weight: bold;"> Mô tả: </span><br> Máy mới 99%, bin 100%, Fullbox chính hãng . Bảo hành 12 tháng tại trung tâm bảo hành ủy quyền chính hãng.</p>
                <p class="product__color">Màu sắc: Sliver</p>

                <div class="btn__buyNow">
                    <p class="amount">Số lượng: <input type="number" min="1" value="1" max="10"> </p>
                    <button class="btn__buy">Mua Ngay</button>
                </div>

            </div>
</asp:Content>