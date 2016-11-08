import sublime, sublime_plugin
import os
import sys
import traceback

class CopyDirPathCommand(sublime_plugin.TextCommand): 
	def run(self, edit):
		ret = sublime.Window.extract_variables(sublime.active_window())
		sublime.set_clipboard(ret["file_path"])
		
class OpenCmdCommand(sublime_plugin.TextCommand): 
	def run(self, edit):
		ret = sublime.Window.extract_variables(sublime.active_window())
		sublime.set_clipboard(ret["file_path"])
		os.chdir(ret["file_path"])
		os.system('start cmd')

class OpenPathCommand(sublime_plugin.TextCommand): 
	'open cur file in dir'
	def run(self, edit):
		ret = sublime.Window.extract_variables(sublime.active_window())
		os.system('explorer.exe  "' + ret["file_path"] + '"')