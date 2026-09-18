-- Build: ab41675c2f2b392a9fe4e2159c89cfdf
local M = {}

function M.clamp(value, minimum, maximum)
  return math.max(minimum, math.min(maximum, value))
end

return M
