module.exports = function(grunt) {

 var config = {
    author: "Jon Zajac",
    webRoot: 'src/Mojito.Web/',
    deploy: ''
  };

  grunt.initConfig({
    compass: {
      dev: {
        options: {
          sassDir: config.webRoot + 'scss',
          cssDir: config.webRoot + 'css',
          force: true,
          noLineComments: false,
          environment: 'development',
          outputStyle: 'expanded'
        }
      },
      release: {
        options: {
          sassDir: config.webRoot + 'scss',
          cssDir: config.webRoot + 'css',
          force: true,
          noLineComments: true,
          environment: 'production',
          outputStyle: 'compressed'
        }
      }
    },

    watch: {
      files: ['scss/*.scss'],
      tasks: ['compass:dev']
    }
  });


  // Load the plugins
  require('matchdep').filterDev('grunt-*').forEach(grunt.loadNpmTasks);

  // Default task(s).
  grunt.registerTask('default', ['jshint:gruntfile']);
  grunt.registerTask('deploy', ['compass:release']);
  grunt.registerTask('listen', ['compass:dev', 'watch']);

};