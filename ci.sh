#!/usr/bin/env bash
# CI for this repo, run from its root by .github/workflows/ci.yml:
#   bash ci.sh build dotnet
#   bash ci.sh format csharpier
# Optional env (set in the workflow): SETUP
set -uo pipefail
mode=$1; shift
TMP=${RUNNER_TEMP:-$(mktemp -d)}
group() { [ -n "${GITHUB_ACTIONS:-}" ] && echo "::group::$1" || echo "== $1"; }
endgroup() { [ -n "${GITHUB_ACTIONS:-}" ] && echo "::endgroup::" || true; }
fail() { echo "${GITHUB_ACTIONS:+::error::}$1 failed"; status=1; }
status=0

if [ -n "${SETUP:-}" ] && [ "$mode" = build ]; then RUNNER_TEMP=$TMP bash -ec "$SETUP" || exit 1; fi

for kind in "$@"; do case "$mode:$kind" in
build:dotnet)
  # every project in one throwaway solution, one folder each (lesson projects often share names)
  { echo '<Solution>'; git ls-files '*.csproj' | while read -r p; do
      echo "  <Folder Name=\"/$(dirname "$p")/\"><Project Path=\"$PWD/$p\" /></Folder>"; done; echo '</Solution>'; } > "$TMP/All.slnx"
  dotnet build "$TMP/All.slnx" -c Release && dotnet test "$TMP/All.slnx" -c Release --no-build ${DOTNET_TEST_FILTER:+--filter "$DOTNET_TEST_FILTER"} || fail "dotnet" ;;
format:csharpier) dotnet tool restore && dotnet csharpier check . || fail csharpier ;;
*) echo "unknown $mode kind: $kind" >&2; exit 2 ;;
esac; done
exit $status
