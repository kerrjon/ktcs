using System.Web.Optimization;

namespace Ktcs
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      const string angularCoreCdn = "//code.angularjs.org/1.2.13/angular.js";
      const string angularRouteCdn = "//ajax.googleapis.com/ajax/libs/angularjs/1.2.13/angular-route.js";
      const string angularAnimateCdn = "//ajax.googleapis.com/ajax/libs/angularjs/1.2.13/angular-animate.js";

      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/angular", angularCoreCdn).Include(
                  "~/Scripts/angular.js"));

      bundles.Add(new ScriptBundle("~/bundles/angular-route", angularRouteCdn).Include(
                  "~/Scripts/angular-route.js"));

      bundles.Add(new ScriptBundle("~/bundles/angular-animate", angularAnimateCdn).Include(
                  "~/Scripts/angular-animate.js"));

      // scripts required in the head
      bundles.Add(new ScriptBundle("~/bundles/adminHeader").Include(
              "~/Scripts/jquery.validate.unobtrusive.js",
              "~/Scripts/jquery.unobtrusive-ajax.js",
              "~/assets/js-core/jquery-core.js",
              "~/assets/js-core/jquery-ui-core.js", 
              "~/assets/js-core/jquery-ui-widget.js", 
              "~/assets/js-core/jquery-ui-mouse.js", 
              "~/assets/js-core/jquery-ui-position.js",
              "~/assets/js-core/modernizr.js",
              "~/assets/js-core/jquery-cookie.js",
              "~/assets/angular/app.js"));

      // scripts required at the bottom of the page
      bundles.Add(new ScriptBundle("~/bundles/admin").Include(
        "~/assets/bootstrap/js/bootstrap.js",
        "~/assets/widgets/progressbar/progressbar.js",
        "~/assets/widgets/superclick/superclick.js",
        "~/assets/widgets/input-switch/inputswitch-alt.js",
        "~/assets/widgets/slimscroll/slimscroll.js",
        "~/assets/widgets/slidebars/slidebars.js",
        "~/assets/widgets/slidebars/slidebars-demo.js",
        "~/assets/widgets/charts/piegage/piegage.js",
        "~/assets/widgets/charts/piegage/piegage-demo.js",
        "~/assets/widgets/screenfull/screenfull.js",
        "~/assets/widgets/content-box/contentbox.js",
        "~/assets/widgets/overlay/overlay.js",
        "~/assets/js-init/widgets-init.js",
        "~/assets/themes/admin/layout.js",
        "~/assets/widgets/theme-switcher/themeswitcher.js"));

      // xCharts
      bundles.Add(new ScriptBundle("~/bundles/xCharts").Include(
        "~/assets/js-core/d3.js",
        "~/assets/widgets/assets/widgets/charts/xcharts/xcharts.js",
        "~/assets/widgets/charts/xcharts/xcharts-demo-1.js"));

      // sparklines Charts
      bundles.Add(new ScriptBundle("~/bundles/sparklineCharts").Include(
        "~/assets/widgets/charts/sparklines/sparklines.js",
        "~/assets/widgets/charts/sparklines/sparklines-demo.js"));

      // Flot Charts
      bundles.Add(new ScriptBundle("~/bundles/flotCharts").Include(
        "~/assets/widgets/charts/flot/flot.js",
        "~/assets/widgets/charts/flot/flot-resize.js",
        "~/assets/widgets/charts/flot/flot-stack.js",
        "~/assets/widgets/charts/flot/flot-pie.js",
        "~/assets/widgets/charts/flot/flot-tooltip.js",
        "~/assets/widgets/charts/flot/flot-demo-1.js"));

      // Calendar
      bundles.Add(new ScriptBundle("~/bundles/calendar").Include(
        "~/assets/widgets/daterangepicker/moment.js",
        "~/assets/widgets/calendar/calendar.js",
        "~/assets/widgets/calendar/calendar-demo.js"));

      // PieGauge charts
      bundles.Add(new ScriptBundle("~/bundles/pieGaugeCharts").Include(
        "~/assets/widgets/charts/piegage/piegage.js",
        "~/assets/widgets/charts/piegage/piegage-demo.js"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

      bundles.Add(new StyleBundle("~/Admin/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/assets/helpers/animate.css",
                "~/assets/helpers/backgrounds.css",
                "~/assets/helpers/boilerplate.css",
                "~/assets/helpers/border-radius.css",
                "~/assets/helpers/grid.css",
                "~/assets/helpers/page-transitions.css",
                "~/assets/helpers/spacing.css",
                "~/assets/helpers/typography.css",
                "~/assets/helpers/utils.css",
                "~/assets/helpers/colors.css",
                "~/assets/elements/badges.css",
                "~/assets/elements/buttons.css",
                "~/assets/elements/content-box.css",
                "~/assets/elements/dashboard-box.css",
                "~/assets/elements/forms.css",
                "~/assets/elements/images.css",
                "~/assets/elements/info-box.css",
                "~/assets/elements/invoice.css",
                "~/assets/elements/loading-indicators.css",
                "~/assets/elements/menus.css",
                "~/assets/elements/panel-box.css",
                "~/assets/elements/response-messages.css",
                "~/assets/elements/responsive-tables.css",
                "~/assets/elements/ribbon.css",
                "~/assets/elements/social-box.css",
                "~/assets/elements/tables.css",
                "~/assets/elements/tile-box.css",
                "~/assets/elements/timeline.css",
                "~/assets/icons/fontawesome/fontawesome.css",
                "~/assets/icons/linecons/linecons.css",
                "~/assets/icons/spinnericon/spinnericon.css",
                "~/assets/widgets/accordion-ui/accordion.css",
                "~/assets/widgets/calendar/calendar.css",
                "~/assets/widgets/carousel/carousel.css",
                "~/assets/widgets/charts/justgage/justgage.css",
                "~/assets/widgets/charts/morris/morris.css",
                "~/assets/widgets/charts/piegage/piegage.css",
                "~/assets/widgets/charts/xcharts/xcharts.css",
                "~/assets/widgets/chosen/chosen.css",
                "~/assets/widgets/colorpicker/colorpicker.css",
                "~/assets/widgets/datatable/datatable.css",
                "~/assets/widgets/datepicker/datepicker.css",
                "~/assets/widgets/datepicker-ui/datepicker.css",
                "~/assets/widgets/daterangepicker/daterangepicker.css",
                "~/assets/widgets/dialog/dialog.css",
                "~/assets/widgets/dropdown/dropdown.css",
                "~/assets/widgets/dropzone/dropzone.css",
                "~/assets/widgets/file-input/fileinput.css",
                "~/assets/widgets/input-switch/inputswitch.css",
                "~/assets/widgets/input-switch/inputswitch-alt.css",
                "~/assets/widgets/ionrangeslider/ionrangeslider.css",
                "~/assets/widgets/jcrop/jcrop.css",
                "~/assets/widgets/jgrowl-notifications/jgrowl.css",
                "~/assets/widgets/loading-bar/loadingbar.css",
                "~/assets/widgets/maps/vector-maps/vectormaps.css",
                "~/assets/widgets/markdown/markdown.css",
                "~/assets/widgets/modal/modal.css",
                "~/assets/widgets/multi-select/multiselect.css",
                "~/assets/widgets/multi-upload/fileupload.css",
                "~/assets/widgets/nestable/nestable.css",
                "~/assets/widgets/noty-notifications/noty.css",
                "~/assets/widgets/popover/popover.css",
                "~/assets/widgets/pretty-photo/prettyphoto.css",
                "~/assets/widgets/progressbar/progressbar.css",
                "~/assets/widgets/range-slider/rangeslider.css",
                "~/assets/widgets/slidebars/slidebars.css",
                "~/assets/widgets/slider-ui/slider.css",
                "~/assets/widgets/summernote-wysiwyg/summernote-wysiwyg.css",
                "~/assets/widgets/tabs-ui/tabs.css",
                "~/assets/widgets/theme-switcher/themeswitcher.css",
                "~/assets/widgets/timepicker/timepicker.css",
                "~/assets/widgets/tocify/tocify.css",
                "~/assets/widgets/tooltip/tooltip.css",
                "~/assets/widgets/touchspin/touchspin.css",
                "~/assets/widgets/uniform/uniform.css",
                "~/assets/widgets/wizard/wizard.css",
                "~/assets/widgets/xeditable/xeditable.css",
                "~/assets/snippets/chat.css",
                "~/assets/snippets/files-box.css",
                "~/assets/snippets/login-box.css",
                "~/assets/snippets/notification-box.css",
                "~/assets/snippets/progress-box.css",
                "~/assets/snippets/todo.css",
                "~/assets/snippets/user-profile.css",
                "~/assets/snippets/mobile-navigation.css",
                "~/assets/applications/mailbox.css",
                "~/assets/themes/admin/layout.css",
                "~/assets/themes/admin/color-schemes/default.css",
                "~/assets/themes/components/default.css",
                "~/assets/themes/components/border-radius.css",
                "~/assets/helpers/responsive-elements.css",
                "~/assets/helpers/admin-responsive.css",
                "~/assets/angular/page-animations.css"));
    }
  }
}
