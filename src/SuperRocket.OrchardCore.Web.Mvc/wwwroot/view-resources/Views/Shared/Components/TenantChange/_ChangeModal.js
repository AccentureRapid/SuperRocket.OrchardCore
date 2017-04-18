﻿(function ($) {
    var _accountService = abp.services.app.account;

    var _$form = $('form[name=TenantChangeForm]');

    _$form.closest('div.modal-content').find(".save-button").click(function (e) {
        e.preventDefault();

        var tenancyName = _$form.find('input[name=TenancyName]').val();

        if (!tenancyName) {
            abp.multiTenancy.setTenantIdCookie(null);
            location.reload();
            return;
        }

        _accountService.isTenantAvailable({
            tenancyName: tenancyName
        }).done(function (result) {
            switch (result.state) {
                case 1: //Available
                    abp.multiTenancy.setTenantIdCookie(result.tenantId);
                    //_modalManager.close();
                    location.reload();
                    return;
                case 2: //InActive
                    abp.message.warn(abp.utils.formatString(abp.localization
                        .localize("TenantIsNotActive", "OrchardCore"),
                        this.tenancyName));
                    break;
                case 3: //NotFound
                    abp.message.warn(abp.utils.formatString(abp.localization
                        .localize("ThereIsNoTenantDefinedWithName{0}", "OrchardCore"),
                        this.tenancyName));
                    break;
            }
        });
    });
})(jQuery);