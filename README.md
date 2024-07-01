# DisableMonsLoot 禁怪物掉落

- 作者: 羽学
- 出处: [github](https://gitee.com/Crafty/bean-points)
- 魔改<怪物不掉钱插件>开发初衷于配合随机掉落物品开荒用
- 此插件通过怪物死亡事件清理当前进度的物品，
- 如击败【怪物ID】任意一个怪物则自动关闭【清理功能】
- 如果开启了【是否全杀】，则需要击败【怪物ID】所有怪物才会自动关闭
- 输入/kdm reset可将所有【清理】开关全部开启，以便重置服务器时还原

## 更新日志
```
v1.3.0
加入指令功能方便重置、控制配置项
默认配置调整清理范围35
克脑 世吞 骷髅王 加入：
魔矿/暗影鳞片/猩红矿/组织样本/骨头/金钥匙

v1.2.0
预设一堆进度物品ID
将怪物ID也改为数组，支持更多ID
加入【是否全杀】配置项
怪物名支持多ID转换中文名
为贴合自动转换中文名避免空引用报错，
在空处输入{},然后reload会预设个示例格式如：

    {
     怪物名":蓝史莱姆",
     清理": false,
     怪物ID": [1],
     物品ID": []
    },

v1.1.0
魔改怪物不掉钱插件
掉落物可用数组控制，击败指定怪物ID，自动关闭清理功能
使用/reload 可取怪物ID赋值给怪物名，自动转换中文名。
```
## 指令

| 语法           |        权限         |   说明   |
| -------------- | :-----------------: | :------: |
| /kdm | killitem.admin  | 查看禁怪掉落指令菜单   |

## 配置
> 配置文件位置：tshock/禁怪物掉落.json
```json
{
  "使用说明": "你只管改‘ID’就行，‘清理’和‘怪物名’不用动，击杀其中1个怪物ID自动关闭清理功能。指令：/kdm (权限killitem.admin)",
  "插件开关": true,
  "是否全杀": false,
  "清理范围": 35,
  "清理列表": [
    {
      "怪物名": "蓝史莱姆, 恶魔眼, 僵尸",
      "清理": true,
      "怪物ID": [
        1,
        2,
        3
      ],
      "物品ID": [
        71,
        72,
        73,
        74
      ]
    }
  ]
}
```
## 反馈
- 优先发issued -> 共同维护的插件库：https://github.com/Controllerdestiny/TShockPlugin
- 次优先：TShock官方群：816771079
- 大概率看不到但是也可以：国内社区trhub.cn ，bbstr.net , tr.monika.love
