angular.module('app', []);
angular.module('app').factory('MyService', function () {
    var records = {};
    

    records.tab1 = false;
    records.tab2 = false;
    records.tab3 = false;
    records.tab4 = false;

    records.region = '';
    records.report = '0';
    records.country = '0';

    records.MainCR = '0';
    records.MainCNC = '0';
    records.CJV = '0';
    records.MainJNCB = '0';
    records.r1a='0';
    records.r2a='0';
    records.r3a='0';
    records.r4a='0';
    records.r5a='0';
    records.r6a='0';
    records.r7a='0';
    records.r8a='0';
    records.r9a='0';
    records.r10a='0';
    records.r11a='0';
    records.r12a='0';
    records.r13a='0';
    records.r14a='0';
    records.r15a='0';
    records.r16a='0';
    records.r17a='0';
    records.r18a='0';
    records.r19a='0';
    records.r20a='0';
    records.r21a='0';
    records.r22a='0';
    records.r23a='0';
    records.r24a ='0';
    records.r25a ='0';
    records.r26a='0';
    records.r27a='0';
    records.r28a='0';
    records.r29a='0';
    records.r30a='0';
    records.r31a='0';
    records.r32a='0';
    records.r33a='0';
    records.r34a='0';
    records.r35a='0';
    records.r36a='0';
    records.r37a='0';
    records.r38a='0';
    records.r39a='0';
    records.r40a='0';
    records.r1b='0';
    records.r2b='0';
    records.r3b='0';
    records.r4b='0';
    records.r5b='0';
    records.r6b='0';
    records.r7b='0';
    records.r8b='0';
    records.r9b='0';
    records.r10b='0';
    records.r11b='0';
    records.r12b='0';
    records.r13b='0';
    records.r14b='0';
    records.r15b='0';
    records.r16b='0';
    records.r17b='0';
    records.r18b='0';
    records.r19b='0';
    records.r20b='0';
    records.r21b='0';
    records.r22b='0';
    records.r23b='0';
    records.r24b ='0';
    records.r25b ='0';
    records.r26b='0';
    records.r27b='0';
    records.r28b='0';
    records.r29b='0';
    records.r30b='0';
    records.r31b='0';
    records.r32b='0';
    records.r33b='0';
    records.r34b='0';
    records.r35b='0';
    records.r36b='0';
    records.r37b='0';
    records.r38b='0';
    records.r39b='0';
    records.r40b='0';
    records.r1c='0';
    records.r2c='0';
    records.r3c='0';
    records.r4c='0';
    records.r5c='0';
    records.r6c='0';
    records.r7c='0';
    records.r8c='0';
    records.r9c='0';
    records.r10c='0';
    records.r11c='0';
    records.r12c='0';
    records.r13c='0';
    records.r14c='0';
    records.r15c='0';
    records.r16c='0';
    records.r17c='0';
    records.r18c='0';
    records.r19c='0';
    records.r20c='0';
    records.r21c='0';
    records.r22c='0';
    records.r23c='0';
    records.r24c='0';
    records.r25c='0';
    records.r26c='0';
    records.r27c='0';
    records.r28c='0';
    records.r29c='0';
    records.r30c='0';
    records.r31c='0';
    records.r32c='0';
    records.r33c='0';
    records.r34c='0';
    records.r35c='0';
    records.r36c='0';
    records.r37c='0';
    records.r38c='0';
    records.r39c='0';
    records.r40c='0';
    records.r1d='0';
    records.r2d='0';
    records.r3d='0';
    records.r4d='0';
    records.r5d='0';
    records.r6d='0';
    records.r7d='0';
    records.r8d='0';
    records.r9d='0';
    records.r10d='0';
    records.r11d='0';
    records.r12d='0';
    records.r13d='0';
    records.r14d='0';
    records.r15d='0';
    records.r16d='0';
    records.r17d='0';
    records.r18d='0';
    records.r19d='0';
    records.r20d='0';
    records.r21d='0';
    records.r22d='0';
    records.r23d='0';
    records.r24d ='0';
    records.r25d ='0';
    records.r26d='0';
    records.r27d='0';
    records.r28d='0';
    records.r29d='0';
    records.r30d='0';
    records.r31d='0';
    records.r32d='0';
    records.r33d='0';
    records.r34d='0';
    records.r35d='0';
    records.r36d='0';
    records.r37d='0';
    records.r38d='0';
    records.r39d='0';
    records.r40d='0';
    records.rmaina = false;
    records.rmainb = false;
    records.rmainc = false;
    records.rmaind = false;
    //MSCtrl
    records.HMS = '0 ';
    records.tcs ='0 ' ;
    records.vc='0';
    //HTCtrl
    records.three1 = false;
    records.three2='0';
    records.three3='0';
    records.three4 = false;
    records.three5='0';
    records.three6='0';
    records.three7='0';
    records.three8='0';
    records.three9='0';
    records.three10='0';
    records.three11 = '0';

    records.changedetails2 = function (region, report, country) {

        records.region = region;
        records.report = report;
        records.country = country;
    };

    records.changedetails1 = function (region,report,country,tab1,tab2,tab3,tab4,MainCR, MainCNC, CJV, MainJNCB, HMS, tcs, vc, three1, three2, three3, three4, three5, three6, three7, three8, three9, three10,three11, rmaina, rmainb, rmainc, rmaind, r1a, r2a, r3a, r4a, r5a, r6a, r7a, r8a, r9a, r10a, r11a, r12a, r13a, r14a, r15a, r16a, r17a, r18a, r19a, r20a, r21a, r22a, r23a, r24a,r25a, r26a, r27a, r28a, r29a, r30a, r31a, r32a, r33a, r34a, r35a, r36a, r37a, r38a, r39a, r40a, r1b, r2b, r3b, r4b, r5b, r6b, r7b, r8b, r9b, r10b, r11b, r12b, r13b, r14b, r15b, r16b, r17b, r18b, r19b, r20b, r21b, r22b, r23b, r24b,r25b, r26b, r27b, r28b, r29b, r30b, r31b, r32b, r33b, r34b, r35b, r36b, r37b, r38b, r39b, r40b, r1c, r2c, r3c, r4c, r5c, r6c, r7c, r8c, r9c, r10c, r11c, r12c, r13c, r14c, r15c, r16c, r17c, r18c, r19c, r20c, r21c, r22c, r23c, r24c,r25c, r26c, r27c, r28c, r29c, r30c, r31c, r32c, r33c, r34c, r35c, r36c, r37c, r38c, r39c, r40c, r1d, r2d, r3d, r4d, r5d, r6d, r7d, r8d, r9d, r10d, r11d, r12d, r13d, r14d, r15d, r16d, r17d, r18d, r19d, r20d, r21d, r22d, r23d, r24d,r25d, r26d, r27d, r28d, r29d, r30d, r31d, r32d, r33d, r34d, r35d, r36d, r37d, r38d, r39d, r40d)
    {
     
        records.region = region;
        records.report = report;
        records.country = country;

        records.tab1 = tab1;
        records.tab2 = tab2;
        records.tab3 = tab3;
        records.tab4 = tab4;
        records.MainCR = MainCR;
        records.MainCNC = MainCNC;
        records.CJV = CJV;
        records.MainJNCB = MainJNCB;
        records.HMS = HMS;
        records.tcs = tcs;
        records.vc = vc;
        records.three1 = three1;
        records.three2 = three2;
        records.three3 = three3;
        records.three4 = three4;
        records.three5 = three5;
        records.three6 = three6;
        records.three7 = three7;
        records.three8 = three8;
        records.three9 = three9;
        records.three10 = three10;
        records.three11 = three11;
        records.rmaina = rmaina;
        records.rmainb = rmainb;
        records.rmainc = rmainc;
        records.rmaind = rmaind;
        records.r1a = r1a;
        records.r2a = r2a;
        records.r3a = r3a;
        records.r4a = r4a;
        records.r5a = r5a;
        records.r6a = r6a;
        records.r7a = r7a;
        records.r8a = r8a;
        records.r9a = r9a;
        records.r10a = r10a;
        records.r11a = r11a;
        records.r12a = r12a;
        records.r13a = r13a;
        records.r14a = r14a;
        records.r15a = r15a;
        records.r16a = r16a;
        records.r17a = r17a;
        records.r18a = r18a;
        records.r19a = r19a;
        records.r20a = r20a;
        records.r21a = r21a;
        records.r22a = r22a;
        records.r23a = r23a;
        records.r24a = r24a;
        records.r25a = r25a;
        records.r26a = r26a;
        records.r27a = r27a;
        records.r28a = r28a;
        records.r29a = r29a;
        records.r30a = r30a;
        records.r31a = r31a;
        records.r32a = r32a;
        records.r33a = r33a;
        records.r34a = r34a;
        records.r35a = r35a;
        records.r36a = r36a;
        records.r37a = r37a;
        records.r38a = r38a;
        records.r39a = r39a;
        records.r40a = r40a;
        records.r1b = r1b;
        records.r2b = r2b;
        records.r3b = r3b;
        records.r4b = r4b;
        records.r5b = r5b;
        records.r6b = r6b;
        records.r7b = r7b;
        records.r8b = r8b;
        records.r9b = r9b;
        records.r10b = r10b;
        records.r11b = r11b;
        records.r12b = r12b;
        records.r13b = r13b;
        records.r14b = r14b;
        records.r15b = r15b;
        records.r16b = r16b;
        records.r17b = r17b;
        records.r18b = r18b;
        records.r19b = r19b;
        records.r20b = r20b;
        records.r21b = r21b;
        records.r22b = r22b;
        records.r23b = r23b;
        records.r24b = r24b;
        records.r25b = r25b;
        records.r26b = r26b;
        records.r27b = r27b;
        records.r28b = r28b;
        records.r29b = r29b;
        records.r30b = r30b;
        records.r31b = r31b;
        records.r32b = r32b;
        records.r33b = r33b;
        records.r34b = r34b;
        records.r35b = r35b;
        records.r36b = r36b;
        records.r37b = r37b;
        records.r38b = r38b;
        records.r39b = r39b;
        records.r40b = r40b;
        records.r1c = r1c;
        records.r2c = r2c;
        records.r3c = r3c;
        records.r4c = r4c;
        records.r5c = r5c;
        records.r6c = r6c;
        records.r7c = r7c;
        records.r8c = r8c;
        records.r9c = r9c;
        records.r10c = r10c;
        records.r11c = r11c;
        records.r12c = r12c;
        records.r13c = r13c;
        records.r14c = r14c;
        records.r15c = r15c;
        records.r16c = r16c;
        records.r17c = r17c;
        records.r18c = r18c;
        records.r19c = r19c;
        records.r20c = r20c;
        records.r21c = r21c;
        records.r22c = r22c;
        records.r23c = r23c;
        records.r24c = r24c;
        records.r25c = r25c;
        records.r26c = r26c;
        records.r27c = r27c;
        records.r28c = r28c;
        records.r29c = r29c;
        records.r30c = r30c;
        records.r31c = r31c;
        records.r32c = r32c;
        records.r33c = r33c;
        records.r34c = r34c;
        records.r35c = r35c;
        records.r36c = r36c;
        records.r37c = r37c;
        records.r38c = r38c;
        records.r39c = r39c;
        records.r40c = r40c;
        records.r1d = r1d;
        records.r2d = r2d;
        records.r3d = r3d;
        records.r4d = r4d;
        records.r5d = r5d;
        records.r6d = r6d;
        records.r7d = r7d;
        records.r8d = r8d;
        records.r9d = r9d;
        records.r10d = r10d;
        records.r11d = r11d;
        records.r12d = r12d;
        records.r13d = r13d;
        records.r14d = r14d;
        records.r15d = r15d;
        records.r16d = r16d;
        records.r17d = r17d;
        records.r18d = r18d;
        records.r19d = r19d;
        records.r20d = r20d;
        records.r21d = r21d;
        records.r22d = r22d;
        records.r23d = r23d;
        records.r24d = r24d;
        records.r25d = r25d;
        records.r26d = r26d;
        records.r27d = r27d;
        records.r28d = r28d;
        records.r29d = r29d;
        records.r30d = r30d;
        records.r31d = r31d;
        records.r32d = r32d;
        records.r33d = r33d;
        records.r34d = r34d;
        records.r35d = r35d;
        records.r36d = r36d;
        records.r37d = r37d;
        records.r38d = r38d;
        records.r39d = r39d;
        records.r40d = r40d;


    };
    return records;

       
});
angular.module('app').controller('MyCtrl2', ['$scope','$http', 'MyService', function ($scope, $http, MyService) {
    $scope.region = MyService.region;
    $scope.report = MyService.report;
    $scope.country = MyService.country;

    $scope.changeName2 = function (region, report, country) {
        $scope.updateServiceName2(region, report, country);
    };
    $scope.updateServiceName2 = function (region, report, country) {
        MyService.changedetails2(region, report, country);
        $scope.region = MyService.region;
        $scope.report = MyService.report;
        $scope.country = MyService.country;
    };
}]);
angular.module('app').controller('MyCtrl', ['$scope','$http', 'MyService', function ($scope, $http, MyService) {
    $scope.before = true;
    $scope.after = false;
    $scope.inprogress = false;

    $scope.region = MyService.region;
    $scope.report = MyService.report;
    $scope.country = MyService.country;

    $scope.tab1 = MyService.tab1;
    $scope.tab2 = MyService.tab2;
    $scope.tab3 = MyService.tab3;
    $scope.tab4 = MyService.tab4;
        $scope.MainCR = MyService.MainCR;
        $scope.MainCNC = MyService.MainCNC;
        $scope.CJV = MyService.CJV;
        $scope.MainJNCB = MyService.MainJNCB;
        $scope.HMS = MyService.HMS;
        $scope.tcs = MyService.tcs;
        $scope.vc = MyService.vc;
        $scope.three1 = MyService.three1;
        $scope.three2 = MyService.three2;
        $scope.three3 = MyService.three3;
        $scope.three4 = MyService.three4;
        $scope.three5 = MyService.three5;
        $scope.three6 = MyService.three6;
        $scope.three7 = MyService.three7;
        $scope.three8 = MyService.three8;
        $scope.three9 = MyService.three9;
        $scope.three10 = MyService.three10;
        $scope.three11 = MyService.three11;
        $scope.rmaina = MyService.rmaina;
        $scope.rmainb = MyService.rmainb;
        $scope.rmainc = MyService.rmainc;
        $scope.rmaind = MyService.rmaind;
        $scope.r1a = MyService.r1a;
        $scope.r2a = MyService.r2a;
        $scope.r3a = MyService.r3a;
        $scope.r4a = MyService.r4a;
        $scope.r5a = MyService.r5a;
        $scope.r6a = MyService.r6a;
        $scope.r7a = MyService.r7a;
        $scope.r8a = MyService.r8a;
        $scope.r9a = MyService.r9a;
        $scope.r10a = MyService.r10a;
        $scope.r11a = MyService.r11a;
        $scope.r12a = MyService.r12a;
        $scope.r13a = MyService.r13a;
        $scope.r14a = MyService.r14a;
        $scope.r15a = MyService.r15a;
        $scope.r16a = MyService.r16a;
        $scope.r17a = MyService.r17a;
        $scope.r18a = MyService.r18a;
        $scope.r19a = MyService.r19a;
        $scope.r20a = MyService.r20a;
        $scope.r21a = MyService.r21a;
        $scope.r22a = MyService.r22a;
        $scope.r23a = MyService.r23a;
        $scope.r24a = MyService.r24a;
        $scope.r25a = MyService.r25a;
        $scope.r26a = MyService.r26a;
        $scope.r27a = MyService.r27a;
        $scope.r28a = MyService.r28a;
        $scope.r29a = MyService.r29a;
        $scope.r30a = MyService.r30a;
        $scope.r31a = MyService.r31a;
        $scope.r32a = MyService.r32a;
        $scope.r33a = MyService.r33a;
        $scope.r34a = MyService.r34a;
        $scope.r35a = MyService.r35a;
        $scope.r36a = MyService.r36a;
        $scope.r37a = MyService.r37a;
        $scope.r38a = MyService.r38a;
        $scope.r39a = MyService.r39a;
        $scope.r40a = MyService.r40a;
        $scope.r1b = MyService.r1b;
        $scope.r2b = MyService.r2b;
        $scope.r3b = MyService.r3b;
        $scope.r4b = MyService.r4b;
        $scope.r5b = MyService.r5b;
        $scope.r6b = MyService.r6b;
        $scope.r7b = MyService.r7b;
        $scope.r8b = MyService.r8b;
        $scope.r9b = MyService.r9b;
        $scope.r10b = MyService.r10b;
        $scope.r11b = MyService.r11b;
        $scope.r12b = MyService.r12b;
        $scope.r13b = MyService.r13b;
        $scope.r14b = MyService.r14b;
        $scope.r15b = MyService.r15b;
        $scope.r16b = MyService.r16b;
        $scope.r17b = MyService.r17b;
        $scope.r18b = MyService.r18b;
        $scope.r19b = MyService.r19b;
        $scope.r20b = MyService.r20b;
        $scope.r21b = MyService.r21b;
        $scope.r22b = MyService.r22b;
        $scope.r23b = MyService.r23b;
        $scope.r24b = MyService.r24b;
        $scope.r25b = MyService.r25b;
        $scope.r26b = MyService.r26b;
        $scope.r27b = MyService.r27b;
        $scope.r28b = MyService.r28b;
        $scope.r29b = MyService.r29b;
        $scope.r30b = MyService.r30b;
        $scope.r31b = MyService.r31b;
        $scope.r32b = MyService.r32b;
        $scope.r33b = MyService.r33b;
        $scope.r34b = MyService.r34b;
        $scope.r35b = MyService.r35b;
        $scope.r36b = MyService.r36b;
        $scope.r37b = MyService.r37b;
        $scope.r38b = MyService.r38b;
        $scope.r39b = MyService.r39b;
        $scope.r40b = MyService.r40b;
        $scope.r1c = MyService.r1c;
        $scope.r2c = MyService.r2c;
        $scope.r3c = MyService.r3c;
        $scope.r4c = MyService.r4c;
        $scope.r5c = MyService.r5c;
        $scope.r6c = MyService.r6c;
        $scope.r7c = MyService.r7c;
        $scope.r8c = MyService.r8c;
        $scope.r9c = MyService.r9c;
        $scope.r10c = MyService.r10c;
        $scope.r11c = MyService.r11c;
        $scope.r12c = MyService.r12c;
        $scope.r13c = MyService.r13c;
        $scope.r14c = MyService.r14c;
        $scope.r15c = MyService.r15c;
        $scope.r16c = MyService.r16c;
        $scope.r17c = MyService.r17c;
        $scope.r18c = MyService.r18c;
        $scope.r19c = MyService.r19c;
        $scope.r20c = MyService.r20c;
        $scope.r21c = MyService.r21c;
        $scope.r22c = MyService.r22c;
        $scope.r23c = MyService.r23c;
        $scope.r24c = MyService.r24c;
        $scope.r25c = MyService.r25c;
        $scope.r26c = MyService.r26c;
        $scope.r27c = MyService.r27c;
        $scope.r28c = MyService.r28c;
        $scope.r29c = MyService.r29c;
        $scope.r30c = MyService.r30c;
        $scope.r31c = MyService.r31c;
        $scope.r32c = MyService.r32c;
        $scope.r33c = MyService.r33c;
        $scope.r34c = MyService.r34c;
        $scope.r35c = MyService.r35c;
        $scope.r36c = MyService.r36c;
        $scope.r37c = MyService.r37c;
        $scope.r38c = MyService.r38c;
        $scope.r39c = MyService.r39c;
        $scope.r40c = MyService.r40c;
        $scope.r1d = MyService.r1d;
        $scope.r2d = MyService.r2d;
        $scope.r3d = MyService.r3d;
        $scope.r4d = MyService.r4d;
        $scope.r5d = MyService.r5d;
        $scope.r6d = MyService.r6d;
        $scope.r7d = MyService.r7d;
        $scope.r8d = MyService.r8d;
        $scope.r9d = MyService.r9d;
        $scope.r10d = MyService.r10d;
        $scope.r11d = MyService.r11d;
        $scope.r12d = MyService.r12d;
        $scope.r13d = MyService.r13d;
        $scope.r14d = MyService.r14d;
        $scope.r15d = MyService.r15d;
        $scope.r16d = MyService.r16d;
        $scope.r17d = MyService.r17d;
        $scope.r18d = MyService.r18d;
        $scope.r19d = MyService.r19d;
        $scope.r20d = MyService.r20d;
        $scope.r21d = MyService.r21d;
        $scope.r22d = MyService.r22d;
        $scope.r23d = MyService.r23d;
        $scope.r24d = MyService.r24d;
        $scope.r25d = MyService.r25d;
        $scope.r26d = MyService.r26d;
        $scope.r27d = MyService.r27d;
        $scope.r28d = MyService.r28d;
        $scope.r29d = MyService.r29d;
        $scope.r30d = MyService.r30d;
        $scope.r31d = MyService.r31d;
        $scope.r32d = MyService.r32d;
        $scope.r33d = MyService.r33d;
        $scope.r34d = MyService.r34d;
        $scope.r35d = MyService.r35d;
        $scope.r36d = MyService.r36d;
        $scope.r37d = MyService.r37d;
        $scope.r38d = MyService.r38d;
        $scope.r39d = MyService.r39d;
        $scope.r40d = MyService.r40d;

       
        $scope.changeName = function (region,report,country,tab1,tab2,tab3,tab4,MainCR, MainCNC, CJV, MainJNCB, HMS, tcs, vc, three1, three2, three3, three4, three5, three6, three7, three8, three9, three10,three11, rmaina, rmainb, rmainc, rmaind, r1a, r2a, r3a, r4a, r5a, r6a, r7a, r8a, r9a, r10a, r11a, r12a, r13a, r14a, r15a, r16a, r17a, r18a, r19a, r20a, r21a, r22a, r23a, r24a,r25a, r26a, r27a, r28a, r29a, r30a, r31a, r32a, r33a, r34a, r35a, r36a, r37a, r38a, r39a, r40a, r1b, r2b, r3b, r4b, r5b, r6b, r7b, r8b, r9b, r10b, r11b, r12b, r13b, r14b, r15b, r16b, r17b, r18b, r19b, r20b, r21b, r22b, r23b, r24b,r25b, r26b, r27b, r28b, r29b, r30b, r31b, r32b, r33b, r34b, r35b, r36b, r37b, r38b, r39b, r40b, r1c, r2c, r3c, r4c, r5c, r6c, r7c, r8c, r9c, r10c, r11c, r12c, r13c, r14c, r15c, r16c, r17c, r18c, r19c, r20c, r21c, r22c, r23c, r24c,r25c, r26c, r27c, r28c, r29c, r30c, r31c, r32c, r33c, r34c, r35c, r36c, r37c, r38c, r39c, r40c, r1d, r2d, r3d, r4d, r5d, r6d, r7d, r8d, r9d, r10d, r11d, r12d, r13d, r14d, r15d, r16d, r17d, r18d, r19d, r20d, r21d, r22d, r23d, r24d,r25d, r26d, r27d, r28d, r29d, r30d, r31d, r32d, r33d, r34d, r35d, r36d, r37d, r38d, r39d, r40d) {
            $scope.updateServiceName(region,report,country,tab1,tab2,tab3,tab4,MainCR, MainCNC, CJV, MainJNCB, HMS, tcs, vc, three1, three2, three3, three4, three5, three6, three7, three8, three9, three10,three11, rmaina, rmainb, rmainc, rmaind, r1a, r2a, r3a, r4a, r5a, r6a, r7a, r8a, r9a, r10a, r11a, r12a, r13a, r14a, r15a, r16a, r17a, r18a, r19a, r20a, r21a, r22a, r23a, r24a,r25a, r26a, r27a, r28a, r29a, r30a, r31a, r32a, r33a, r34a, r35a, r36a, r37a, r38a, r39a, r40a, r1b, r2b, r3b, r4b, r5b, r6b, r7b, r8b, r9b, r10b, r11b, r12b, r13b, r14b, r15b, r16b, r17b, r18b, r19b, r20b, r21b, r22b, r23b, r24b,r25b, r26b, r27b, r28b, r29b, r30b, r31b, r32b, r33b, r34b, r35b, r36b, r37b, r38b, r39b, r40b, r1c, r2c, r3c, r4c, r5c, r6c, r7c, r8c, r9c, r10c, r11c, r12c, r13c, r14c, r15c, r16c, r17c, r18c, r19c, r20c, r21c, r22c, r23c, r24c,r25c, r26c, r27c, r28c, r29c, r30c, r31c, r32c, r33c, r34c, r35c, r36c, r37c, r38c, r39c, r40c, r1d, r2d, r3d, r4d, r5d, r6d, r7d, r8d, r9d, r10d, r11d, r12d, r13d, r14d, r15d, r16d, r17d, r18d, r19d, r20d, r21d, r22d, r23d, r24d,r25d, r26d, r27d, r28d, r29d, r30d, r31d, r32d, r33d, r34d, r35d, r36d, r37d, r38d, r39d, r40d);
        };
        $scope.updateServiceName = function (region, report, country, tab1, tab2, tab3, tab4, MainCR, MainCNC, CJV, MainJNCB, HMS, tcs, vc, three1, three2, three3, three4, three5, three6, three7, three8, three9, three10,three11, rmaina, rmainb, rmainc, rmaind, r1a, r2a, r3a, r4a, r5a, r6a, r7a, r8a, r9a, r10a, r11a, r12a, r13a, r14a, r15a, r16a, r17a, r18a, r19a, r20a, r21a, r22a, r23a, r24a, r25a, r26a, r27a, r28a, r29a, r30a, r31a, r32a, r33a, r34a, r35a, r36a, r37a, r38a, r39a, r40a, r1b, r2b, r3b, r4b, r5b, r6b, r7b, r8b, r9b, r10b, r11b, r12b, r13b, r14b, r15b, r16b, r17b, r18b, r19b, r20b, r21b, r22b, r23b, r24b, r25b, r26b, r27b, r28b, r29b, r30b, r31b, r32b, r33b, r34b, r35b, r36b, r37b, r38b, r39b, r40b, r1c, r2c, r3c, r4c, r5c, r6c, r7c, r8c, r9c, r10c, r11c, r12c, r13c, r14c, r15c, r16c, r17c, r18c, r19c, r20c, r21c, r22c, r23c, r24c, r25c, r26c, r27c, r28c, r29c, r30c, r31c, r32c, r33c, r34c, r35c, r36c, r37c, r38c, r39c, r40c, r1d, r2d, r3d, r4d, r5d, r6d, r7d, r8d, r9d, r10d, r11d, r12d, r13d, r14d, r15d, r16d, r17d, r18d, r19d, r20d, r21d, r22d, r23d, r24d, r25d, r26d, r27d, r28d, r29d, r30d, r31d, r32d, r33d, r34d, r35d, r36d, r37d, r38d, r39d, r40d) {
            MyService.changedetails1(region, report, country, tab1, tab2, tab3, tab4, MainCR, MainCNC, CJV, MainJNCB, HMS, tcs, vc, three1, three2, three3, three4, three5, three6, three7, three8, three9, three10,three11, rmaina, rmainb, rmainc, rmaind, r1a, r2a, r3a, r4a, r5a, r6a, r7a, r8a, r9a, r10a, r11a, r12a, r13a, r14a, r15a, r16a, r17a, r18a, r19a, r20a, r21a, r22a, r23a, r24a, r25a, r26a, r27a, r28a, r29a, r30a, r31a, r32a, r33a, r34a, r35a, r36a, r37a, r38a, r39a, r40a, r1b, r2b, r3b, r4b, r5b, r6b, r7b, r8b, r9b, r10b, r11b, r12b, r13b, r14b, r15b, r16b, r17b, r18b, r19b, r20b, r21b, r22b, r23b, r24b, r25b, r26b, r27b, r28b, r29b, r30b, r31b, r32b, r33b, r34b, r35b, r36b, r37b, r38b, r39b, r40b, r1c, r2c, r3c, r4c, r5c, r6c, r7c, r8c, r9c, r10c, r11c, r12c, r13c, r14c, r15c, r16c, r17c, r18c, r19c, r20c, r21c, r22c, r23c, r24c, r25c, r26c, r27c, r28c, r29c, r30c, r31c, r32c, r33c, r34c, r35c, r36c, r37c, r38c, r39c, r40c, r1d, r2d, r3d, r4d, r5d, r6d, r7d, r8d, r9d, r10d, r11d, r12d, r13d, r14d, r15d, r16d, r17d, r18d, r19d, r20d, r21d, r22d, r23d, r24d, r25d, r26d, r27d, r28d, r29d, r30d, r31d, r32d, r33d, r34d, r35d, r36d, r37d, r38d, r39d, r40d);
            $scope.region = MyService.region;
            $scope.report = MyService.report;
            $scope.country = MyService.country;
            $scope.tab1 = MyService.tab1;
            $scope.tab2 = MyService.tab2;
            $scope.tab3 = MyService.tab3;
            $scope.tab4 = MyService.tab4;
            $scope.MainCR = MyService.MainCR;
            $scope.MainCNC = MyService.MainCNC;
            $scope.CJV = MyService.CJV;
            $scope.MainJNCB = MyService.MainJNCB;
            $scope.HMS = MyService.HMS;
            $scope.tcs = MyService.tcs;
            $scope.vc = MyService.vc;
            $scope.three1 = MyService.three1;
            $scope.three2 = MyService.three2;
            $scope.three3 = MyService.three3;
            $scope.three4 = MyService.three4;
            $scope.three5 = MyService.three5;
            $scope.three6 = MyService.three6;
            $scope.three7 = MyService.three7;
            $scope.three8 = MyService.three8;
            $scope.three9 = MyService.three9;
            $scope.three10 = MyService.three10;
            $scope.three11 = MyService.three11;
            $scope.rmaina = MyService.rmaina;
            $scope.rmainb = MyService.rmainb;
            $scope.rmainc = MyService.rmainc;
            $scope.rmaind = MyService.rmaind;
            $scope.r1a = MyService.r1a;
            $scope.r2a = MyService.r2a;
            $scope.r3a = MyService.r3a;
            $scope.r4a = MyService.r4a;
            $scope.r5a = MyService.r5a;
            $scope.r6a = MyService.r6a;
            $scope.r7a = MyService.r7a;
            $scope.r8a = MyService.r8a;
            $scope.r9a = MyService.r9a;
            $scope.r10a = MyService.r10a;
            $scope.r11a = MyService.r11a;
            $scope.r12a = MyService.r12a;
            $scope.r13a = MyService.r13a;
            $scope.r14a = MyService.r14a;
            $scope.r15a = MyService.r15a;
            $scope.r16a = MyService.r16a;
            $scope.r17a = MyService.r17a;
            $scope.r18a = MyService.r18a;
            $scope.r19a = MyService.r19a;
            $scope.r20a = MyService.r20a;
            $scope.r21a = MyService.r21a;
            $scope.r22a = MyService.r22a;
            $scope.r23a = MyService.r23a;
            $scope.r24a = MyService.r24a;
            $scope.r25a = MyService.r25a;
            $scope.r26a = MyService.r26a;
            $scope.r27a = MyService.r27a;
            $scope.r28a = MyService.r28a;
            $scope.r29a = MyService.r29a;
            $scope.r30a = MyService.r30a;
            $scope.r31a = MyService.r31a;
            $scope.r32a = MyService.r32a;
            $scope.r33a = MyService.r33a;
            $scope.r34a = MyService.r34a;
            $scope.r35a = MyService.r35a;
            $scope.r36a = MyService.r36a;
            $scope.r37a = MyService.r37a;
            $scope.r38a = MyService.r38a;
            $scope.r39a = MyService.r39a;
            $scope.r40a = MyService.r40a;
            $scope.r1b = MyService.r1b;
            $scope.r2b = MyService.r2b;
            $scope.r3b = MyService.r3b;
            $scope.r4b = MyService.r4b;
            $scope.r5b = MyService.r5b;
            $scope.r6b = MyService.r6b;
            $scope.r7b = MyService.r7b;
            $scope.r8b = MyService.r8b;
            $scope.r9b = MyService.r9b;
            $scope.r10b = MyService.r10b;
            $scope.r11b = MyService.r11b;
            $scope.r12b = MyService.r12b;
            $scope.r13b = MyService.r13b;
            $scope.r14b = MyService.r14b;
            $scope.r15b = MyService.r15b;
            $scope.r16b = MyService.r16b;
            $scope.r17b = MyService.r17b;
            $scope.r18b = MyService.r18b;
            $scope.r19b = MyService.r19b;
            $scope.r20b = MyService.r20b;
            $scope.r21b = MyService.r21b;
            $scope.r22b = MyService.r22b;
            $scope.r23b = MyService.r23b;
            $scope.r24b = MyService.r24b;
            $scope.r25b = MyService.r25b;
            $scope.r26b = MyService.r26b;
            $scope.r27b = MyService.r27b;
            $scope.r28b = MyService.r28b;
            $scope.r29b = MyService.r29b;
            $scope.r30b = MyService.r30b;
            $scope.r31b = MyService.r31b;
            $scope.r32b = MyService.r32b;
            $scope.r33b = MyService.r33b;
            $scope.r34b = MyService.r34b;
            $scope.r35b = MyService.r35b;
            $scope.r36b = MyService.r36b;
            $scope.r37b = MyService.r37b;
            $scope.r38b = MyService.r38b;
            $scope.r39b = MyService.r39b;
            $scope.r40b = MyService.r40b;
            $scope.r1c = MyService.r1c;
            $scope.r2c = MyService.r2c;
            $scope.r3c = MyService.r3c;
            $scope.r4c = MyService.r4c;
            $scope.r5c = MyService.r5c;
            $scope.r6c = MyService.r6c;
            $scope.r7c = MyService.r7c;
            $scope.r8c = MyService.r8c;
            $scope.r9c = MyService.r9c;
            $scope.r10c = MyService.r10c;
            $scope.r11c = MyService.r11c;
            $scope.r12c = MyService.r12c;
            $scope.r13c = MyService.r13c;
            $scope.r14c = MyService.r14c;
            $scope.r15c = MyService.r15c;
            $scope.r16c = MyService.r16c;
            $scope.r17c = MyService.r17c;
            $scope.r18c = MyService.r18c;
            $scope.r19c = MyService.r19c;
            $scope.r20c = MyService.r20c;
            $scope.r21c = MyService.r21c;
            $scope.r22c = MyService.r22c;
            $scope.r23c = MyService.r23c;
            $scope.r24c = MyService.r24c;
            $scope.r25c = MyService.r25c;
            $scope.r26c = MyService.r26c;
            $scope.r27c = MyService.r27c;
            $scope.r28c = MyService.r28c;
            $scope.r29c = MyService.r29c;
            $scope.r30c = MyService.r30c;
            $scope.r31c = MyService.r31c;
            $scope.r32c = MyService.r32c;
            $scope.r33c = MyService.r33c;
            $scope.r34c = MyService.r34c;
            $scope.r35c = MyService.r35c;
            $scope.r36c = MyService.r36c;
            $scope.r37c = MyService.r37c;
            $scope.r38c = MyService.r38c;
            $scope.r39c = MyService.r39c;
            $scope.r40c = MyService.r40c;
            $scope.r1d = MyService.r1d;
            $scope.r2d = MyService.r2d;
            $scope.r3d = MyService.r3d;
            $scope.r4d = MyService.r4d;
            $scope.r5d = MyService.r5d;
            $scope.r6d = MyService.r6d;
            $scope.r7d = MyService.r7d;
            $scope.r8d = MyService.r8d;
            $scope.r9d = MyService.r9d;
            $scope.r10d = MyService.r10d;
            $scope.r11d = MyService.r11d;
            $scope.r12d = MyService.r12d;
            $scope.r13d = MyService.r13d;
            $scope.r14d = MyService.r14d;
            $scope.r15d = MyService.r15d;
            $scope.r16d = MyService.r16d;
            $scope.r17d = MyService.r17d;
            $scope.r18d = MyService.r18d;
            $scope.r19d = MyService.r19d;
            $scope.r20d = MyService.r20d;
            $scope.r21d = MyService.r21d;
            $scope.r22d = MyService.r22d;
            $scope.r23d = MyService.r23d;
            $scope.r24d = MyService.r24d;
            $scope.r25d = MyService.r25d;
            $scope.r26d = MyService.r26d;
            $scope.r27d = MyService.r27d;
            $scope.r28d = MyService.r28d;
            $scope.r29d = MyService.r29d;
            $scope.r30d = MyService.r30d;
            $scope.r31d = MyService.r31d;
            $scope.r32d = MyService.r32d;
            $scope.r33d = MyService.r33d;
            $scope.r34d = MyService.r34d;
            $scope.r35d = MyService.r35d;
            $scope.r36d = MyService.r36d;
            $scope.r37d = MyService.r37d;
            $scope.r38d = MyService.r38d;
            $scope.r39d = MyService.r39d;
            $scope.r40d = MyService.r40d;

        };

    //new code calling ajax method to update basic info
        $scope.Savebasicinfo = function () {
            var country = $('#country').val();
            var region = $('#region').val();
            var report = $('#report').val();
            $http({
                method: 'POST',
                url: '/Home1/Savebasicinfo',
                data: {
                    country: country,
                    state: region,
                    region: report
                },

                //forms user object
                headers: { 'Content-Type': 'application/json' }
            })
            .success(function (data) { });

        };
    //end==new code calling ajax method to update basic info


        $scope.getlastrundetails = function () {
            $.getJSON("/Home1/getlastrundetails",
    function (data) {
        // $scope.three1 = data.three1;  //commented as thee not values
        $scope.three2 = data.three2;
        $scope.three3 = data.three3;
        // $scope.three4 = data.three4; //commented as thee not values
        $scope.three5 = data.three5;
        $scope.three6 = data.three6;
        $scope.three7 = data.three7;
        $scope.three8 = data.three8;
        $scope.three9 = data.three9;
        $scope.three10 = data.three10;
        $scope.three11 = data.three11;

    }
);
        };
    //newcode to pull default Values  getdefaultthree3
        $scope.getdefaultthree3 = function () {
           
            $.getJSON("/Home1/getdefaultthree3",
    function (data) {
       // $scope.three1 = data.three1;  //commented as thee not values
        $scope.three2 = data.three2;
        $scope.three3 = data.three3;
        // $scope.three4 = data.three4; //commented as thee not values
        $scope.three5 = data.three5;
        $scope.three6 = data.three6;
        $scope.three7 = data.three7;
        $scope.three8 = data.three8;
        $scope.three9 = data.three9;
        $scope.three10 = data.three10;
        $scope.three11 = data.three11;
       
    }
);
       
        };
    //end of new to pull default values
        

    //newcode to pull default Values  getdefaulfour4
        $scope.getdefaulfour4 = function () {

            $.getJSON("/Home1/getdefaulfour4",
    function (data) {
        $scope.HMS = data.HMS;
        $scope.tcs = data.tcs;
        $scope.vc = data.vc;

    }
);

        };
    //end of new to pull default values




    //newcode to pull default Values  getdefaultone
        $scope.getdefaultone1 = function () {

            $.getJSON("/Home1/getdefaultone1",
    function (data) {
        $scope.MainCR = data.MainCR;
        $scope.MainCNC = data.MainCNC;
        $scope.CJV = data.CJV;
        $scope.MainJNCB = data.MainJNCB;

    }
);

        };
    //end of new to pull default values

    //newcode to pull default Values  getdefault=L+pne+1
        $scope.getdefaultlone1 = function () {

            $.getJSON("/Home1/getdefaultlone1",
    function (data) {
        $scope.r7a = data.r7a;
        $scope.r8a = data.r8a;
        $scope.r9a = data.r9a;
        $scope.r10a = data.r10a;
        $scope.r11a = data.r11a;
        $scope.r12a = data.r12a;
        $scope.r13a = data.r13a;
        $scope.r14a = data.r14a;
        $scope.r15a = data.r15a;
        $scope.r16a = data.r16a;
        $scope.r17a = data.r17a;
        $scope.r18a = data.r18a;
        $scope.r19a = data.r19a;
        $scope.r20a = data.r20a;
        $scope.r21a = data.r21a;
        $scope.r22a = data.r22a;
        $scope.r23a = data.r23a;
        $scope.r24a = data.r24a;
        $scope.r25a = data.r25a;
        $scope.r26a = data.r26a;
        $scope.r27a = data.r27a;
        $scope.r28a = data.r28a;
        $scope.r29a = data.r29a;
        $scope.r30a = data.r30a;
        $scope.r31a = data.r31a;
        $scope.r32a = data.r32a;
        $scope.r33a = data.r33a;
        $scope.r34a = data.r34a;
        $scope.r35a = data.r35a;
        $scope.r36a = data.r36a;
        $scope.r37a = data.r37a;
        $scope.r38a = data.r38a;
        $scope.r39a = data.r39a;
        $scope.r40a = data.r40a;

    }
);

        };
    //end of new to pull default values
    // /newcode to pull default Values  getdefaultltwo2
        $scope.getdefaultltwo2 = function () {

            $.getJSON("/Home1/getdefaultltwo2",
    function (data) {
        $scope.r7b = data.r7b;
        $scope.r8b = data.r8b;
        $scope.r9b = data.r9b;
        $scope.r10b = data.r10b;
        $scope.r11b = data.r11b;
        $scope.r12b = data.r12b;
        $scope.r13b = data.r13b;
        $scope.r14b = data.r14b;
        $scope.r15b = data.r15b;
        $scope.r16b = data.r16b;
        $scope.r17b = data.r17b;
        $scope.r18b = data.r18b;
        $scope.r19b = data.r19b;
        $scope.r20b = data.r20b;
        $scope.r21b = data.r21b;
        $scope.r22b = data.r22b;
        $scope.r23b = data.r23b;
        $scope.r24b = data.r24b;
        $scope.r25b = data.r25b;
        $scope.r26b = data.r26b;
        $scope.r27b = data.r27b;
        $scope.r28b = data.r28b;
        $scope.r29b = data.r29b;
        $scope.r30b = data.r30b;
        $scope.r31b = data.r31b;
        $scope.r32b = data.r32b;
        $scope.r33b = data.r33b;
        $scope.r34b = data.r34b;
        $scope.r35b = data.r35b;
        $scope.r36b = data.r36b;
        $scope.r37b = data.r37b;
        $scope.r38b = data.r38b;
        $scope.r39b = data.r39b;
        $scope.r40b = data.r40b;

    }
);

        };
    //end of new to pull default values
    // /newcode to pull default Values  getdefaultlthree3
        $scope.getdefaultlthree3 = function () {

            $.getJSON("/Home1/getdefaultlthree3",
    function (data) {
        $scope.r7c = data.r7c;
        $scope.r8c = data.r8c;
        $scope.r9c = data.r9c;
        $scope.r10c = data.r10c;
        $scope.r11c = data.r11c;
        $scope.r12c = data.r12c;
        $scope.r13c = data.r13c;
        $scope.r14c = data.r14c;
        $scope.r15c = data.r15c;
        $scope.r16c = data.r16c;
        $scope.r17c = data.r17c;
        $scope.r18c = data.r18c;
        $scope.r19c = data.r19c;
        $scope.r20c = data.r20c;
        $scope.r21c = data.r21c;
        $scope.r22c = data.r22c;
        $scope.r23c = data.r23c;
        $scope.r24c = data.r24c;
        $scope.r25c = data.r25c;
        $scope.r26c = data.r26c;
        $scope.r27c = data.r27c;
        $scope.r28c = data.r28c;
        $scope.r29c = data.r29c;
        $scope.r30c = data.r30c;
        $scope.r31c = data.r31c;
        $scope.r32c = data.r32c;
        $scope.r33c = data.r33c;
        $scope.r34c = data.r34c;
        $scope.r35c = data.r35c;
        $scope.r36c = data.r36c;
        $scope.r37c = data.r37c;
        $scope.r38c = data.r38c;
        $scope.r39c = data.r39c;
        $scope.r40c = data.r40c; 
    }
);

        };
    //end of new to pull default values
    //newcode to pull default Values  getdefaultlfour4
        $scope.getdefaultlfour4 = function () {

            $.getJSON("/Home1/getdefaultlfour4",
    function (data) {
        $scope.r7d = data.r7d;
        $scope.r8d = data.r8d;
        $scope.r9d = data.r9d;
        $scope.r10d = data.r10d;
        $scope.r11d = data.r11d;
        $scope.r12d = data.r12d;
        $scope.r13d = data.r13d;
        $scope.r14d = data.r14d;
        $scope.r15d = data.r15d;
        $scope.r16d = data.r16d;
        $scope.r17d = data.r17d;
        $scope.r18d = data.r18d;
        $scope.r19d = data.r19d;
        $scope.r20d = data.r20d;
        $scope.r21d = data.r21d;
        $scope.r22d = data.r22d;
        $scope.r23d = data.r23d;
        $scope.r24d = data.r24d;
        $scope.r25d = data.r25d;
        $scope.r26d = data.r26d;
        $scope.r27d = data.r27d;
        $scope.r28d = data.r28d;
        $scope.r29d = data.r29d;
        $scope.r30d = data.r30d;
        $scope.r31d = data.r31d;
        $scope.r32d = data.r32d;
        $scope.r33d = data.r33d;
        $scope.r34d = data.r34d;
        $scope.r35d = data.r35d;
        $scope.r36d = data.r36d;
        $scope.r37d = data.r37d;
        $scope.r38d = data.r38d;
        $scope.r39d = data.r39d;
        $scope.r40d = data.r40d;

    }
);

        };
    //end of new to pull default values


    ///here is code below  ajx
        $scope.user = {};
         // calling our submit function.
        $scope.submitForm = function () {
            
            //collecting data
            var myData = {};
            myData.region = MyService.region;
            myData.report = MyService.report;
            myData.country = MyService.country;

            myData.tab1 = MyService.tab1;
            myData.tab2 = MyService.tab2;
            myData.tab3 = MyService.tab3;
            myData.tab4 = MyService.tab4;
            myData.MainCR = MyService.MainCR;
            myData.MainCNC = MyService.MainCNC;// $scope.MainCNC;
            myData.CJV = MyService.CJV;//   $scope.CJV;
            myData.MainJNCB = MyService.MainJNCB;
            myData.HMS = MyService.HMS;
            myData.tcs = MyService.tcs;
            myData.vc = MyService.vc;
            myData.three1 = MyService.three1;
            myData.three2 = MyService.three2;
            myData.three3 = MyService.three3;
            myData.three4 = MyService.three4;
            myData.three5 = MyService.three5;
            myData.three6 = MyService.three6;
            myData.three7 = MyService.three7;
            myData.three8 = MyService.three8;
            myData.three9 = MyService.three9;
            myData.three10 = MyService.three10;
            myData.three11 = MyService.three11;
            myData.rmaina = MyService.rmaina;
            myData.rmainb = MyService.rmainb;
            myData.rmainc = MyService.rmainc;
            myData.rmaind = MyService.rmaind;
            myData.r1a = MyService.r1a;
            myData.r2a = MyService.r2a;
            myData.r3a = MyService.r3a;
            myData.r4a = MyService.r4a;
            myData.r5a = MyService.r5a;
            myData.r6a = MyService.r6a;
            myData.r7a = MyService.r7a;
            myData.r8a = MyService.r8a;
            myData.r9a = MyService.r9a;
            myData.r10a = MyService.r10a;
            myData.r11a = MyService.r11a;
            myData.r12a = MyService.r12a;
            myData.r13a = MyService.r13a;
            myData.r14a = MyService.r14a;
            myData.r15a = MyService.r15a;
            myData.r16a = MyService.r16a;
            myData.r17a = MyService.r17a;
            myData.r18a = MyService.r18a;
            myData.r19a = MyService.r19a;
            myData.r20a = MyService.r20a;
            myData.r21a = MyService.r21a;
            myData.r22a = MyService.r22a;
            myData.r23a = MyService.r23a;

            myData.r24a = MyService.r24a;
            myData.r25a = MyService.r25a;
            myData.r26a = MyService.r26a;
            myData.r27a = MyService.r27a;
            myData.r28a = MyService.r28a;
            myData.r29a = MyService.r29a;
            myData.r30a = MyService.r30a;
            myData.r31a = MyService.r31a;
            myData.r32a = MyService.r32a;
            myData.r33a = MyService.r33a;
            myData.r34a = MyService.r34a;
            myData.r35a = MyService.r35a;
            myData.r36a = MyService.r36a;
            myData.r37a = MyService.r37a;
            myData.r38a = MyService.r38a;
            myData.r39a = MyService.r39a;
            myData.r40a = MyService.r40a;
            myData.r1b = MyService.r1b;
            myData.r2b = MyService.r2b;
            myData.r3b = MyService.r3b;
            myData.r4b = MyService.r4b;
            myData.r5b = MyService.r5b;
            myData.r6b = MyService.r6b;
            myData.r7b = MyService.r7b;
            myData.r8b = MyService.r8b;
            myData.r9b = MyService.r9b;
            myData.r10b = MyService.r10b;
            myData.r11b = MyService.r11b;
            myData.r12b = MyService.r12b;
            myData.r13b = MyService.r13b;
            myData.r14b = MyService.r14b;
            myData.r15b = MyService.r15b;
            myData.r16b = MyService.r16b;
            myData.r17b = MyService.r17b;
            myData.r18b = MyService.r18b;
            myData.r19b = MyService.r19b;
            myData.r20b = MyService.r20b;
            myData.r21b = MyService.r21b;
            myData.r22b = MyService.r22b;
            myData.r23b = MyService.r23b;
            myData.r24b = MyService.r24b;
            myData.r25b = MyService.r25b;
            myData.r26b = MyService.r26b;
            myData.r27b = MyService.r27b;
            myData.r28b = MyService.r28b;
            myData.r29b = MyService.r29b;
            myData.r30b = MyService.r30b;
            myData.r31b = MyService.r31b;
            myData.r32b = MyService.r32b;
            myData.r33b = MyService.r33b;
            myData.r34b = MyService.r34b;
            myData.r35b = MyService.r35b;
            myData.r36b = MyService.r36b;
            myData.r37b = MyService.r37b;
            myData.r38b = MyService.r38b;
            myData.r39b = MyService.r39b;
            myData.r40b = MyService.r40b;
            myData.r1c = MyService.r1c;
            myData.r2c = MyService.r2c;
            myData.r3c = MyService.r3c;
            myData.r4c = MyService.r4c;
            myData.r5c = MyService.r5c;
            myData.r6c = MyService.r6c;
            myData.r7c = MyService.r7c;
            myData.r8c = MyService.r8c;
            myData.r9c = MyService.r9c;
            myData.r10c = MyService.r10c;
            myData.r11c = MyService.r11c;
            myData.r12c = MyService.r12c;
            myData.r13c = MyService.r13c;
            myData.r14c = MyService.r14c;
            myData.r15c = MyService.r15c;
            myData.r16c = MyService.r16c;
            myData.r17c = MyService.r17c;
            myData.r18c = MyService.r18c;
            myData.r19c = MyService.r19c;
            myData.r20c = MyService.r20c;
            myData.r21c = MyService.r21c;
            myData.r22c = MyService.r22c;
            myData.r23c = MyService.r23c;
            myData.r24c = MyService.r24c;
            myData.r25c = MyService.r25c;

            myData.r26c = MyService.r26c;
            myData.r27c = MyService.r27c;
            myData.r28c = MyService.r28c;
            myData.r29c = MyService.r29c;
            myData.r30c = MyService.r30c;
            myData.r31c = MyService.r31c;
            myData.r32c = MyService.r32c;
            myData.r33c = MyService.r33c;
            myData.r34c = MyService.r34c;
            myData.r35c = MyService.r35c;
            myData.r36c = MyService.r36c;
            myData.r37c = MyService.r37c;
            myData.r38c = MyService.r38c;
            myData.r39c = MyService.r39c;
            myData.r40c = MyService.r40c;
            myData.r1d = MyService.r1d;
            myData.r2d = MyService.r2d;
            myData.r3d = MyService.r3d;
            myData.r4d = MyService.r4d;
            myData.r5d = MyService.r5d;
            myData.r6d = MyService.r6d;
            myData.r7d = MyService.r7d;
            myData.r8d = MyService.r8d;
            myData.r9d = MyService.r9d;
            myData.r10d = MyService.r10d;
            myData.r11d = MyService.r11d;
            myData.r12d = MyService.r12d;
            myData.r13d = MyService.r13d;
            myData.r14d = MyService.r14d;
            myData.r15d = MyService.r15d;
            myData.r16d = MyService.r16d;
            myData.r17d = MyService.r17d;
            myData.r18d = MyService.r18d;
            myData.r19d = MyService.r19d;
            myData.r20d = MyService.r20d;
            myData.r21d = MyService.r21d;
            myData.r22d = MyService.r22d;
            myData.r23d = MyService.r23d;
            myData.r24d = MyService.r24d;
            myData.r25d = MyService.r25d;
            myData.r26d = MyService.r26d;
            myData.r27d = MyService.r27d;
            myData.r28d = MyService.r28d;
            myData.r29d = MyService.r29d;
            myData.r30d = MyService.r30d;
            myData.r31d = MyService.r31d;
            myData.r32d = MyService.r32d;
            myData.r33d = MyService.r33d;
            myData.r34d = MyService.r34d;
            myData.r35d = MyService.r35d;
            myData.r36d = MyService.r36d;
            myData.r37d = MyService.r37d;
            myData.r38d = MyService.r38d;
            myData.r39d = MyService.r39d;
            myData.r40d = MyService.r40d;

            var data = JSON.stringify(myData);


            // Posting data to server
            $scope.before = false;
            $scope.after = false;
            $scope.inprogress = true;
            $http({
                method: 'POST',
                url: '/Home1/getreport',
                data: data,
               
                 //forms user object
                headers: { 'Content-Type': 'application/json' }
            })
              .success(function (data) {
                  if (data.errors) {
                      // Showing errors.
                      //$scope.errorName = data.errors.name;
                      //$scope.errorUserName = data.errors.username;
                      //$scope.errorEmail = data.errors.email;

                      $scope.before = true;
                      $scope.after =false;
                      $scope.inprogress = false;
                  } else {
                      //$scope.message = data.message;
                      alert('Ganesh');

                      $scope.before = false;
                      $scope.after = true;
                      $scope.inprogress = false;
                  }
              });
       
        };

        $scope.restting = function () {
            $scope.before = true;
            $scope.after = false;
            $scope.inprogress = false;
            $scope.inprogress = false;

        };
      
        $scope.report1 = function () {
            window.location = 'Home/report1';
        };


    
}]);
angular.module('app').controller('TabsCtrl', ['$scope', function ($scope) {
    $scope.tabs = [{
        title: 'One',
        img: 'http://localhost:21891/Images/1.jpg',
        url: '/Scripts/one1.tpl.html'
    }, {
        title: 'Two',
        img: 'http://localhost:21891/Images/2.jpg',
        url: '/Scripts/two2.tpl.html'
    }, {
        title: 'Three',
        img: 'http://localhost:21891/Images/3.jpg',
        url: '/Scripts/three3.tpl.html'
    }, {
        title: 'Four',
        img: 'http://localhost:21891/Images/4.jpg',
        url: '/Scripts/four4.tpl.html'
    }];

    $scope.currentTab = '/Scripts/one1.tpl.html';

    $scope.onClickTab = function (tab) {
        $scope.currentTab = tab.url;
    }
    
    $scope.isActiveTab = function(tabUrl) {
        return tabUrl == $scope.currentTab;
    }

    $scope.ltabs = [{
        title: 'One',
        img: 'http://localhost:21891/Images/1.jpg',
        url: '/Scripts/lone1.tpl.html'
    }, {
        title: 'Two',
        img: 'http://localhost:21891/Images/2.jpg',
        url: '/Scripts/ltwo2.tpl.html'
    }, {
        title: 'Three',
        img: 'http://localhost:21891/Images/3.jpg',
        url: '/Scripts/lthree3.tpl.html'
    }, {
        title: 'Four',
        img: 'http://localhost:21891/Images/4.jpg',
        url: '/Scripts/lfour4.tpl.html'
    }];

    $scope.lcurrentTab = '/Scripts/lone1.tpl.html';

    $scope.lonClickTab = function (ltab) {
        $scope.lcurrentTab = ltab.url;
    }

    $scope.lisActiveTab = function (ltabUrl) {
        return ltabUrl == $scope.lcurrentTab;
    }

}]);

angular.module('app').controller('SecondCtrl', ['$scope', function ($scope) {
 
}]);

//function savebsicinfo() {
  
       // <------------------ stop default behaviour of button
        