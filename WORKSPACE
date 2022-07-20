workspace(name = "root_workspace")
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

# git_repository(name = "rules_unreal", remote = "git@github.com:arctictheory/bazel_rules_unreal.git", commit = "23b4fce4ccbd966cc31572fbeb0bf2355ec743fa")

new_local_repository(
    name = "unreal_engine",
    build_file = "@rules_unreal//ue5/engine:ue5_engine.BUILD",
    path = "C:/Work/Epic/UE_5.0"
    )

local_repository(
    name = "rules_unreal",
    path = "C:/Work/bazel-rules-unreal"
    )


http_archive(
    name = "rules_python",
    sha256 = "9fcf91dbcc31fde6d1edb15f117246d912c33c36f44cf681976bd886538deba6",
    strip_prefix = "rules_python-0.8.0",
    url = "https://github.com/bazelbuild/rules_python/archive/refs/tags/0.8.0.tar.gz",
)

load("@rules_python//python:repositories.bzl", "python_register_toolchains")
python_register_toolchains(
    name = "python3_9",
    python_version = "3.9",
)

load("@python3_9//:defs.bzl", "interpreter")