
local Time = Time

local fl_tUpdate = {name="fl_tUpdate"}
function fl_tUpdate:Update()
	-- print(self.name, Time.deltaTime, Time.unscaledDeltaTime)
end

--主入口函数。从这里开始lua逻辑
function Main()					
	print("主入口函数。从这里开始lua逻辑")

	-- UpdateBeat:Add(function()
	-- 	print(Time.deltaTime, Time.unscaledDeltaTime)
	-- end)	
	UpdateBeat:Add(fl_tUpdate.Update, fl_tUpdate) 
	
	Test()
end

--场景切换通知
function OnLevelWasLoaded(level)
	Time.timeSinceLevelLoad = 0
end

function Test( ... )
	local Color = UnityEngine.Color
    local GameObject = UnityEngine.GameObject
    local ParticleSystem = UnityEngine.ParticleSystem

    function OnComplete()
        print('OnComplete CallBack')
    end       

    print(typeof)                
    print(typeof(ParticleSystem))                
    
    local go = GameObject('go')
    go:AddComponent(typeof(ParticleSystem))
    local node = go.transform
    node.position = Vector3.one      
    print('gameObject is: '..tostring(go))                 
    --go.transform:DOPath({Vector3.zero, Vector3.one * 10}, 1, DG.Tweening.PathType.Linear, DG.Tweening.PathMode.Full3D, 10, nil)
    --go.transform:DORotate(Vector3(0,0,360), 2, DG.Tweening.RotateMode.FastBeyond360):OnComplete(OnComplete)
    --GameObject.Destroy(go, 20)                  
    print('delay destroy gameobject is: '..go.name)
end