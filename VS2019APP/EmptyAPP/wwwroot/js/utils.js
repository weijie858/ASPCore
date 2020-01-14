
//获取查询参数
var getParam = function (obj) {
    var model = {};
    $("#" + obj + " .form-control[isparam!=no]").each(function () {
        var key = $(this).data('key');
        var val = $(this).val();
        model[key] = val;
    });
    return model;
}



var TextEmpty = function (obj) {
    if ($("#" + obj + " .form-control[check=no]").length > 0) {
        $("#" + obj + " .form-control[check!=no]").val("");
    } else {
        //$("#" + obj + " .form-control[readonly!=readonly]").val("");
        $("#" + obj + " .form-control").val("");
    }
    $("#" + obj + " :radio").eq(0).prop("checked", true);
    //删除多选
    if ($('#' + obj).find('select').hasClass('multiselect')) {
        $('#' + obj).find('ul').find('li').each(function () {
            if ($(this).prop("className") == 'active') {
                $(this).find('label').trigger('click');
            }
        })
    }
}
//

//

//#region 下拉绑定
var bindSelectFun = function (args) {
    var defaults = {
        $bindSelectId: null,
        postUrl: "",
        postdata: {}
    }
    $.extend(defaults, args);
    defaults.$bindSelectId.empty().append("<option selected=\"selected\" value=\"\"></option>");
    $.post(defaults.postUrl, defaults.postdata, function (datas) {
        var options = "";
        $.each(datas, function (key, val) {
            options += "<option value=\"" + key + "\">" + val + "</option>";
        });
        $(options).appendTo(defaults.$bindSelectId);
    });
}

bindSelectFun({
    $bindSelectId: $("#search_passageway_b"),
    postUrl: "/Commom/GetBPassagewayId",
    postdata: {}
});
//#endregion