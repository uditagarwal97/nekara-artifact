# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.10

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration

# Include any dependencies generated for this target.
include CMakeFiles/mutual_exclusion.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/mutual_exclusion.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/mutual_exclusion.dir/flags.make

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o: CMakeFiles/mutual_exclusion.dir/flags.make
CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o: mutual_exclusion.cc
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o -c /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/mutual_exclusion.cc

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/mutual_exclusion.dir/mutual_exclusion.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/mutual_exclusion.cc > CMakeFiles/mutual_exclusion.dir/mutual_exclusion.i

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/mutual_exclusion.dir/mutual_exclusion.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/mutual_exclusion.cc -o CMakeFiles/mutual_exclusion.dir/mutual_exclusion.s

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.requires:

.PHONY : CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.requires

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.provides: CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.requires
	$(MAKE) -f CMakeFiles/mutual_exclusion.dir/build.make CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.provides.build
.PHONY : CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.provides

CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.provides.build: CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o


# Object files for target mutual_exclusion
mutual_exclusion_OBJECTS = \
"CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o"

# External object files for target mutual_exclusion
mutual_exclusion_EXTERNAL_OBJECTS =

mutual_exclusion: CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o
mutual_exclusion: CMakeFiles/mutual_exclusion.dir/build.make
mutual_exclusion: CMakeFiles/mutual_exclusion.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable mutual_exclusion"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/mutual_exclusion.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/mutual_exclusion.dir/build: mutual_exclusion

.PHONY : CMakeFiles/mutual_exclusion.dir/build

CMakeFiles/mutual_exclusion.dir/requires: CMakeFiles/mutual_exclusion.dir/mutual_exclusion.o.requires

.PHONY : CMakeFiles/mutual_exclusion.dir/requires

CMakeFiles/mutual_exclusion.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/mutual_exclusion.dir/cmake_clean.cmake
.PHONY : CMakeFiles/mutual_exclusion.dir/clean

CMakeFiles/mutual_exclusion.dir/depend:
	cd /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration /home/udit/coyote-scheduler-pct-ffi/coyote-scheduler/test/integration/CMakeFiles/mutual_exclusion.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/mutual_exclusion.dir/depend

