var monarchApp = angular.module('monarchApp', ['ngRoute', 'ngAnimate']);

// configure our routes
monarchApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/admin/demo/', {
            templateUrl: 'admin/demo',
            controller: 'indexController'
        })
        .when('/admin/demo/index', {
            templateUrl: 'admin/demo',
            controller: 'indexController'
        })
        .when('/advanced-datatables', {
            templateUrl: 'admin/demo/advanced-datatables',
            controller: 'advanced-datatablesController'
        })
        .when('/animations', {
            templateUrl: 'admin/demo/animations',
            controller: 'animationsController'
        })
        .when('/bs-carousel', {
            templateUrl: 'admin/demo/bs-carousel',
            controller: 'bs-carouselController'
        })
        .when('/buttons', {
            templateUrl: 'admin/demo/buttons',
            controller: 'buttonsController'
        })
        .when('/calendar', {
            templateUrl: 'admin/demo/calendar',
            controller: 'calendarController'
        })
        .when('/chart-boxes', {
            templateUrl: 'admin/demo/chart-boxes',
            controller: 'chart-boxesController'
        })
        .when('/chart-js', {
            templateUrl: 'admin/demo/chart-js',
            controller: 'chart-jsController'
        })
        .when('/chat', {
            templateUrl: 'admin/demo/chat',
            controller: 'chatController'
        })
        .when('/checklist', {
            templateUrl: 'admin/demo/checklist',
            controller: 'checklistController'
        })
        .when('/ckeditor', {
            templateUrl: 'admin/demo/ckeditor',
            controller: 'ckeditorController'
        })
        .when('/collapsable', {
            templateUrl: 'admin/demo/collapsable',
            controller: 'collapsableController'
        })
        .when('/content-boxes', {
            templateUrl: 'admin/demo/content-boxes',
            controller: 'content-boxesController'
        })
        .when('/data-tables', {
            templateUrl: 'admin/demo/data-tables',
            controller: 'data-tablesController'
        })
        .when('/dropzone-uploader', {
            templateUrl: 'admin/demo/dropzone-uploader',
            controller: 'dropzone-uploaderController'
        })
        .when('/fixed-datatables', {
            templateUrl: 'admin/demo/fixed-datatables',
            controller: 'fixed-datatablesController'
        })
        .when('/flot-charts', {
            templateUrl: 'admin/demo/flot-charts',
            controller: 'flot-chartsController'
        })
        .when('/forms-elements', {
            templateUrl: 'admin/demo/forms-elements',
            controller: 'forms-elementsController'
        })
        .when('/forms-masks', {
            templateUrl: 'admin/demo/forms-masks',
            controller: 'forms-masksController'
        })
        .when('/forms-validation', {
            templateUrl: 'admin/demo/forms-validation',
            controller: 'forms-validationController'
        })
        .when('/forms-wizard', {
            templateUrl: 'admin/demo/forms-wizard',
            controller: 'forms-wizardController'
        })
        .when('/gmaps', {
            templateUrl: 'admin/demo/gmaps',
            controller: 'gmapsController'
        })
        .when('/helper-classes', {
            templateUrl: 'admin/demo/helper-classes',
            controller: 'helper-classesController'
        })
        .when('/icons', {
            templateUrl: 'admin/demo/icons',
            controller: 'iconsController'
        })
        .when('/image-crop', {
            templateUrl: 'admin/demo/image-crop',
            controller: 'image-cropController'
        })
        .when('/images', {
            templateUrl: 'admin/demo/images',
            controller: 'imagesController'
        })
        .when('/index-alt', {
            templateUrl: 'admin/demo/index-alt',
            controller: 'index-altController'
        })
        .when('/inline-editor', {
            templateUrl: 'admin/demo/inline-editor',
            controller: 'inline-editorController'
        })
        .when('/input-knobs', {
            templateUrl: 'admin/demo/input-knobs',
            controller: 'input-knobsController'
        })
        .when('/just-gage', {
            templateUrl: 'admin/demo/just-gage',
            controller: 'just-gageController'
        })
        .when('/labels-badges', {
            templateUrl: 'admin/demo/labels-badges',
            controller: 'labels-badgesController'
        })
        .when('/lazyload', {
            templateUrl: 'admin/demo/lazyload',
            controller: 'lazyloadController'
        })
        .when('/loading-feedback', {
            templateUrl: 'admin/demo/loading-feedback',
            controller: 'loading-feedbackController'
        })
        .when('/mailbox-compose', {
            templateUrl: 'admin/demo/mailbox-compose',
            controller: 'mailbox-composeController'
        })
        .when('/mailbox-inbox', {
            templateUrl: 'admin/demo/mailbox-inbox',
            controller: 'mailbox-inboxController'
        })
        .when('/mailbox-single', {
            templateUrl: 'admin/demo/mailbox-single',
            controller: 'mailbox-singleController'
        })
        .when('/mapael', {
            templateUrl: 'admin/demo/mapael',
            controller: 'mapaelController'
        })
        .when('/markdown', {
            templateUrl: 'admin/demo/markdown',
            controller: 'markdownController'
        })
        .when('/modals', {
            templateUrl: 'admin/demo/modals',
            controller: 'modalsController'
        })
        .when('/morris-charts', {
            templateUrl: 'admin/demo/morris-charts',
            controller: 'morris-chartsController'
        })
        .when('/multi-uploader', {
            templateUrl: 'admin/demo/multi-uploader',
            controller: 'multi-uploaderController'
        })
        .when('/nav-menus', {
            templateUrl: 'admin/demo/nav-menus',
            controller: 'nav-menusController'
        })
        .when('/notifications', {
            templateUrl: 'admin/demo/notifications',
            controller: 'notificationsController'
        })
        .when('/page-transitions', {
            templateUrl: 'admin/demo/page-transitions',
            controller: 'page-transitionsController'
        })
        .when('/panel-boxes', {
            templateUrl: 'admin/demo/panel-boxes',
            controller: 'panel-boxesController'
        })
        .when('/pickers', {
            templateUrl: 'admin/demo/pickers',
            controller: 'pickersController'
        })
        .when('/pie-gages', {
            templateUrl: 'admin/demo/pie-gages',
            controller: 'pie-gagesController'
        })
        .when('/popovers-tooltips', {
            templateUrl: 'admin/demo/popovers-tooltips',
            controller: 'popovers-tooltipsController'
        })
        .when('/progress-bars', {
            templateUrl: 'admin/demo/progress-bars',
            controller: 'progress-barsController'
        })
        .when('/response-messages', {
            templateUrl: 'admin/demo/response-messages',
            controller: 'response-messagesController'
        })
        .when('/responsive-datatables', {
            templateUrl: 'admin/demo/responsive-datatables',
            controller: 'responsive-datatablesController'
        })
        .when('/responsive-tables', {
            templateUrl: 'admin/demo/responsive-tables',
            controller: 'responsive-tablesController'
        })
        .when('/scrollbars', {
            templateUrl: 'admin/demo/scrollbars',
            controller: 'scrollbarsController'
        })
        .when('/sliders', {
            templateUrl: 'admin/demo/sliders',
            controller: 'slidersController'
        })
        .when('/social-boxes', {
            templateUrl: 'admin/demo/social-boxes',
            controller: 'social-boxesController'
        })
        .when('/sortable-elements', {
            templateUrl: 'admin/demo/sortable-elements',
            controller: 'sortable-elementsController'
        })
        .when('/sparklines', {
            templateUrl: 'admin/demo/sparklines',
            controller: 'sparklinesController'
        })
        .when('/summernote', {
            templateUrl: 'admin/demo/summernote',
            controller: 'summernoteController'
        })
        .when('/tables', {
            templateUrl: 'admin/demo/tables',
            controller: 'tablesController'
        })
        .when('/tabs', {
            templateUrl: 'admin/demo/tabs',
            controller: 'tabsController'
        })
        .when('/tile-boxes', {
            templateUrl: 'admin/demo/tile-boxes',
            controller: 'tile-boxesController'
        })
        .when('/timeline', {
            templateUrl: 'admin/demo/timeline',
            controller: 'timelineController'
        })
        .when('/vector-maps', {
            templateUrl: 'admin/demo/vector-maps',
            controller: 'vector-mapsController'
        })
        .when('/xcharts', {
            templateUrl: 'admin/demo/xcharts',
            controller: 'xchartsController'
        })
        .when('/admin-blog', {
            templateUrl: 'admin/demo/admin-blog',
            controller: 'admin-blogController'
        })
        .when('/admin-pricing', {
            templateUrl: 'admin/demo/admin-pricing',
            controller: 'admin-pricingController'
        })
        .when('/auto-menu', {
            templateUrl: 'admin/demo/auto-menu',
            controller: 'auto-menuController'
        })
        .when('/faq-section', {
            templateUrl: 'admin/demo/faq-section',
            controller: 'faq-sectionController'
        })
        .when('/invoice', {
            templateUrl: 'admin/demo/invoice',
            controller: 'invoiceController'
        })
        .when('/portfolio-gallery', {
            templateUrl: 'admin/demo/portfolio-gallery',
            controller: 'portfolio-galleryController'
        })
        .when('/portfolio-masonry', {
            templateUrl: 'admin/demo/portfolio-masonry',
            controller: 'portfolio-masonryController'
        })
        .when('/slidebars', {
            templateUrl: 'admin/demo/slidebars',
            controller: 'slidebarsController'
        })
        .when('/view-profile', {
            templateUrl: 'admin/demo/view-profile',
            controller: 'view-profileController'
        });
    // use the HTML5 History API
    $locationProvider.html5Mode(true);
});


monarchApp.controller('indexController', function($scope) {
    $scope.subheading = "Muy Title";
});

monarchApp.controller('advanced-datatablesController', function($scope) {
    
});

monarchApp.controller('animationsController', function($scope) {
    
});

monarchApp.controller('bs-carouselController', function($scope) {
    
});

monarchApp.controller('buttonsController', function($scope) {
    $scope.subheading = "Muy Title";
});

monarchApp.controller('calendarController', function($scope) {
    
});

monarchApp.controller('chart-boxesController', function($scope) {
    
});

monarchApp.controller('chart-jsController', function($scope) {
    
});

monarchApp.controller('chatController', function($scope) {
    
});

monarchApp.controller('checklistController', function($scope) {
    
});

monarchApp.controller('ckeditorController', function($scope) {
    
});

monarchApp.controller('collapsableController', function($scope) {
    
});

monarchApp.controller('content-boxesController', function($scope) {
    
});

monarchApp.controller('data-tablesController', function($scope) {
    
});

monarchApp.controller('dropzone-uploaderController', function($scope) {
    
});

monarchApp.controller('fixed-datatablesController', function($scope) {
    
});

monarchApp.controller('flot-chartsController', function($scope) {
    
});

monarchApp.controller('forms-elementsController', function($scope) {
    
});

monarchApp.controller('forms-masksController', function($scope) {
    
});

monarchApp.controller('forms-validationController', function($scope) {
    
});

monarchApp.controller('forms-wizardController', function($scope) {
    
});

monarchApp.controller('gmapsController', function($scope) {
    
});

monarchApp.controller('helper-classesController', function($scope) {
    
});

monarchApp.controller('iconsController', function($scope) {
    
});

monarchApp.controller('image-cropController', function($scope) {
    
});

monarchApp.controller('imagesController', function($scope) {
    
});

monarchApp.controller('indexController', function($scope) {
    
});

monarchApp.controller('index-altController', function($scope) {
    
});

monarchApp.controller('inline-editorController', function($scope) {
    
});

monarchApp.controller('input-knobsController', function($scope) {
    
});

monarchApp.controller('just-gageController', function($scope) {
    
});

monarchApp.controller('labels-badgesController', function($scope) {
    
});

monarchApp.controller('lazyloadController', function($scope) {
    
});

monarchApp.controller('loading-feedbackController', function($scope) {
    
});

monarchApp.controller('mailbox-composeController', function($scope) {
    
});

monarchApp.controller('mailbox-inboxController', function($scope) {
    
});

monarchApp.controller('mailbox-singleController', function($scope) {
    
});

monarchApp.controller('mapaelController', function($scope) {
    
});

monarchApp.controller('markdownController', function($scope) {
    
});

monarchApp.controller('modalsController', function($scope) {
    
});

monarchApp.controller('morris-chartsController', function($scope) {
    
});

monarchApp.controller('multi-uploaderController', function($scope) {
    
});

monarchApp.controller('nav-menusController', function($scope) {
    
});

monarchApp.controller('notificationsController', function($scope) {
    
});

monarchApp.controller('page-transitionsController', function($scope) {
    
});

monarchApp.controller('panel-boxesController', function($scope) {
    
});

monarchApp.controller('pickersController', function($scope) {
    
});

monarchApp.controller('pie-gagesController', function($scope) {
    
});

monarchApp.controller('popovers-tooltipsController', function($scope) {
    
});

monarchApp.controller('progress-barsController', function($scope) {
    
});

monarchApp.controller('response-messagesController', function($scope) {
    
});

monarchApp.controller('responsive-datatablesController', function($scope) {
    
});

monarchApp.controller('responsive-tablesController', function($scope) {
    
});

monarchApp.controller('scrollbarsController', function($scope) {
    
});

monarchApp.controller('slidersController', function($scope) {
    
});

monarchApp.controller('social-boxesController', function($scope) {
    
});

monarchApp.controller('sortable-elementsController', function($scope) {
    
});

monarchApp.controller('sparklinesController', function($scope) {
    
});

monarchApp.controller('summernoteController', function($scope) {
    
});

monarchApp.controller('tablesController', function($scope) {
    
});

monarchApp.controller('tabsController', function($scope) {
    
});

monarchApp.controller('tile-boxesController', function($scope) {
    
});

monarchApp.controller('timelineController', function($scope) {
    
});

monarchApp.controller('vector-mapsController', function($scope) {
    
});

monarchApp.controller('xchartsController', function($scope) {
    
});

monarchApp.controller('admin-blogController', function($scope){

});

monarchApp.controller('admin-pricingController', function($scope){

});

monarchApp.controller('auto-menuController', function($scope){

});

monarchApp.controller('faq-sectionController', function($scope){

});

monarchApp.controller('invoiceController', function($scope){

});

monarchApp.controller('portfolio-galleryController', function($scope){

});

monarchApp.controller('portfolio-masonryController', function($scope){

});

monarchApp.controller('slidebarsController', function($scope){

});

monarchApp.controller('view-profileController', function($scope){

});

