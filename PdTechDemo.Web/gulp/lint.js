'use strict';

var gulp = require('gulp');
var cache = require('gulp-cached');
// var eslint = require('gulp-eslint');
var jshint = require('gulp-jshint');
var stylish = require('jshint-stylish');
var scsslint = require('gulp-scss-lint');

// Lint JS.
//gulp.task('lintjs', function () {
//  return gulp.src(global.paths.js)
//    .pipe(cache('lintjs'))
//    .pipe(eslint())
//    .pipe(eslint.format());
//});

// Lint JS.
gulp.task('lintjs', function () {
  return gulp.src(global.paths.js)
    .pipe(jshint())
    .pipe(jshint.reporter(stylish))
});

// Lint SASS.
gulp.task('lintsass', function () {
  return gulp.src(global.paths.sass)
    .pipe(cache('lintsass'))
    .pipe(scsslint());
});

// Lint all the things!
gulp.task('lint', ['lintjs', 'lintsass']);
