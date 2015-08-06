(function() {
  'use strict';

  angular
    .module('pdTechDemoWeb')
    .run(runBlock);

  /** @ngInject */
  function runBlock($log) {

    $log.debug('runBlock end');
  }

})();
