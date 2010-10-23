/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class GameImpl : Game {
  private HandleRef swigCPtr;

  internal GameImpl(IntPtr cPtr, bool cMemoryOwn) : base(bridgePINVOKE.GameImpl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GameImpl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GameImpl() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_GameImpl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is GameImpl)
      equal = (((GameImpl)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(GameImpl obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(GameImpl obj1, GameImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(GameImpl obj1, GameImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Event makeEvent(BWAPIC_Event e) {
    Event ret = new Event(bridgePINVOKE.GameImpl_makeEvent(swigCPtr, BWAPIC_Event.getCPtr(e)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int addUnitCommand(BWAPIC_UnitCommand c) {
    int ret = bridgePINVOKE.GameImpl_addUnitCommand(swigCPtr, BWAPIC_UnitCommand.getCPtr(c));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool inGame {
    set {
      bridgePINVOKE.GameImpl_inGame_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.GameImpl_inGame_get(swigCPtr);
      return ret;
    } 
  }

  public GameImpl(GameData data) : this(bridgePINVOKE.new_GameImpl(GameData.getCPtr(data)), true) {
  }

  public void onMatchStart() {
    bridgePINVOKE.GameImpl_onMatchStart(swigCPtr);
  }

  public void onMatchEnd() {
    bridgePINVOKE.GameImpl_onMatchEnd(swigCPtr);
  }

  public void onMatchFrame() {
    bridgePINVOKE.GameImpl_onMatchFrame(swigCPtr);
  }

  public virtual UnitPtrSet getPlayerUnits(Player player) {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getPlayerUnits(swigCPtr, Player.getCPtr(player)), false);
    return ret;
  }

  public override ForcePtrSet getForces() {
    ForcePtrSet ret = new ForcePtrSet(bridgePINVOKE.GameImpl_getForces(swigCPtr), false);
    return ret;
  }

  public override PlayerPtrSet getPlayers() {
    PlayerPtrSet ret = new PlayerPtrSet(bridgePINVOKE.GameImpl_getPlayers(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getAllUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getAllUnits(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getMinerals() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getMinerals(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getGeysers() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getGeysers(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getNeutralUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getNeutralUnits(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getStaticMinerals() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getStaticMinerals(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getStaticGeysers() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getStaticGeysers(swigCPtr), false);
    return ret;
  }

  public override UnitPtrSet getStaticNeutralUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getStaticNeutralUnits(swigCPtr), false);
    return ret;
  }

  public override BulletPtrSet getBullets() {
    BulletPtrSet ret = new BulletPtrSet(bridgePINVOKE.GameImpl_getBullets(swigCPtr), false);
    return ret;
  }

  public override EventList getEvents() {
    EventList ret = new EventList(bridgePINVOKE.GameImpl_getEvents(swigCPtr), false);
    return ret;
  }

  public override Force getForce(int forceID) {
    IntPtr cPtr = bridgePINVOKE.GameImpl_getForce(swigCPtr, forceID);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

  public override Player getPlayer(int playerID) {
    IntPtr cPtr = bridgePINVOKE.GameImpl_getPlayer(swigCPtr, playerID);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public override Unit getUnit(int unitID) {
    IntPtr cPtr = bridgePINVOKE.GameImpl_getUnit(swigCPtr, unitID);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Unit indexToUnit(int unitIndex) {
    IntPtr cPtr = bridgePINVOKE.GameImpl_indexToUnit(swigCPtr, unitIndex);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override GameType getGameType() {
    GameType ret = new GameType(bridgePINVOKE.GameImpl_getGameType(swigCPtr), true);
    return ret;
  }

  public override int getLatency() {
    int ret = bridgePINVOKE.GameImpl_getLatency(swigCPtr);
    return ret;
  }

  public override int getFrameCount() {
    int ret = bridgePINVOKE.GameImpl_getFrameCount(swigCPtr);
    return ret;
  }

  public override int getFPS() {
    int ret = bridgePINVOKE.GameImpl_getFPS(swigCPtr);
    return ret;
  }

  public override double getAverageFPS() {
    double ret = bridgePINVOKE.GameImpl_getAverageFPS(swigCPtr);
    return ret;
  }

  public override int getMouseX() {
    int ret = bridgePINVOKE.GameImpl_getMouseX(swigCPtr);
    return ret;
  }

  public override int getMouseY() {
    int ret = bridgePINVOKE.GameImpl_getMouseY(swigCPtr);
    return ret;
  }

  public override Position getMousePosition() {
    Position ret = new Position(bridgePINVOKE.GameImpl_getMousePosition(swigCPtr), true);
    return ret;
  }

  public override bool getMouseState(MouseButton button) {
    bool ret = bridgePINVOKE.GameImpl_getMouseState__SWIG_0(swigCPtr, (int)button);
    return ret;
  }

  public override bool getMouseState(int button) {
    bool ret = bridgePINVOKE.GameImpl_getMouseState__SWIG_1(swigCPtr, button);
    return ret;
  }

  public override bool getKeyState(Key key) {
    bool ret = bridgePINVOKE.GameImpl_getKeyState__SWIG_0(swigCPtr, (int)key);
    return ret;
  }

  public override bool getKeyState(int key) {
    bool ret = bridgePINVOKE.GameImpl_getKeyState__SWIG_1(swigCPtr, key);
    return ret;
  }

  public override int getScreenX() {
    int ret = bridgePINVOKE.GameImpl_getScreenX(swigCPtr);
    return ret;
  }

  public override int getScreenY() {
    int ret = bridgePINVOKE.GameImpl_getScreenY(swigCPtr);
    return ret;
  }

  public override Position getScreenPosition() {
    Position ret = new Position(bridgePINVOKE.GameImpl_getScreenPosition(swigCPtr), true);
    return ret;
  }

  public override void setScreenPosition(int x, int y) {
    bridgePINVOKE.GameImpl_setScreenPosition__SWIG_0(swigCPtr, x, y);
  }

  public override void setScreenPosition(Position p) {
    bridgePINVOKE.GameImpl_setScreenPosition__SWIG_1(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void pingMinimap(int x, int y) {
    bridgePINVOKE.GameImpl_pingMinimap__SWIG_0(swigCPtr, x, y);
  }

  public override void pingMinimap(Position p) {
    bridgePINVOKE.GameImpl_pingMinimap__SWIG_1(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isFlagEnabled(int flag) {
    bool ret = bridgePINVOKE.GameImpl_isFlagEnabled(swigCPtr, flag);
    return ret;
  }

  public override void enableFlag(int flag) {
    bridgePINVOKE.GameImpl_enableFlag(swigCPtr, flag);
  }

  public override UnitPtrSet unitsOnTile(int x, int y) {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_unitsOnTile(swigCPtr, x, y), false);
    return ret;
  }

  public override Error getLastError() {
    Error ret = new Error(bridgePINVOKE.GameImpl_getLastError(swigCPtr), true);
    return ret;
  }

  public override int mapWidth() {
    int ret = bridgePINVOKE.GameImpl_mapWidth(swigCPtr);
    return ret;
  }

  public override int mapHeight() {
    int ret = bridgePINVOKE.GameImpl_mapHeight(swigCPtr);
    return ret;
  }

  public override string mapFileName() {
    string ret = bridgePINVOKE.GameImpl_mapFileName(swigCPtr);
    return ret;
  }

  public override string mapPathName() {
    string ret = bridgePINVOKE.GameImpl_mapPathName(swigCPtr);
    return ret;
  }

  public override string mapName() {
    string ret = bridgePINVOKE.GameImpl_mapName(swigCPtr);
    return ret;
  }

  public override string mapHash() {
    string ret = bridgePINVOKE.GameImpl_mapHash(swigCPtr);
    return ret;
  }

  public override bool isWalkable(int x, int y) {
    bool ret = bridgePINVOKE.GameImpl_isWalkable(swigCPtr, x, y);
    return ret;
  }

  public override int getGroundHeight(int x, int y) {
    int ret = bridgePINVOKE.GameImpl_getGroundHeight__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public override int getGroundHeight(TilePosition position) {
    int ret = bridgePINVOKE.GameImpl_getGroundHeight__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isBuildable(int x, int y) {
    bool ret = bridgePINVOKE.GameImpl_isBuildable__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public override bool isBuildable(TilePosition position) {
    bool ret = bridgePINVOKE.GameImpl_isBuildable__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isVisible(int x, int y) {
    bool ret = bridgePINVOKE.GameImpl_isVisible__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public override bool isVisible(TilePosition position) {
    bool ret = bridgePINVOKE.GameImpl_isVisible__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isExplored(int x, int y) {
    bool ret = bridgePINVOKE.GameImpl_isExplored__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public override bool isExplored(TilePosition position) {
    bool ret = bridgePINVOKE.GameImpl_isExplored__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasCreep(int x, int y) {
    bool ret = bridgePINVOKE.GameImpl_hasCreep__SWIG_0(swigCPtr, x, y);
    return ret;
  }

  public override bool hasCreep(TilePosition position) {
    bool ret = bridgePINVOKE.GameImpl_hasCreep__SWIG_1(swigCPtr, TilePosition.getCPtr(position));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasPower(int x, int y, int tileWidth, int tileHeight) {
    bool ret = bridgePINVOKE.GameImpl_hasPower__SWIG_0(swigCPtr, x, y, tileWidth, tileHeight);
    return ret;
  }

  public override bool hasPower(TilePosition position, int tileWidth, int tileHeight) {
    bool ret = bridgePINVOKE.GameImpl_hasPower__SWIG_1(swigCPtr, TilePosition.getCPtr(position), tileWidth, tileHeight);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool canBuildHere(Unit builder, TilePosition position, UnitType type) {
    bool ret = bridgePINVOKE.GameImpl_canBuildHere(swigCPtr, Unit.getCPtr(builder), TilePosition.getCPtr(position), UnitType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool canMake(Unit builder, UnitType type) {
    bool ret = bridgePINVOKE.GameImpl_canMake(swigCPtr, Unit.getCPtr(builder), UnitType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool canResearch(Unit unit, TechType type) {
    bool ret = bridgePINVOKE.GameImpl_canResearch(swigCPtr, Unit.getCPtr(unit), TechType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool canUpgrade(Unit unit, UpgradeType type) {
    bool ret = bridgePINVOKE.GameImpl_canUpgrade(swigCPtr, Unit.getCPtr(unit), UpgradeType.getCPtr(type));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TilePositionSet getStartLocations() {
    TilePositionSet ret = new TilePositionSet(bridgePINVOKE.GameImpl_getStartLocations(swigCPtr), false);
    return ret;
  }

  public override void printf(string text) {
    bridgePINVOKE.GameImpl_printf(swigCPtr, text);
  }

  public override void sendText(string text) {
    bridgePINVOKE.GameImpl_sendText(swigCPtr, text);
  }

  public override void sendTextEx(bool toAllies, string format) {
    bridgePINVOKE.GameImpl_sendTextEx(swigCPtr, toAllies, format);
  }

  public override void changeRace(Race race) {
    bridgePINVOKE.GameImpl_changeRace(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isInGame() {
    bool ret = bridgePINVOKE.GameImpl_isInGame(swigCPtr);
    return ret;
  }

  public override bool isMultiplayer() {
    bool ret = bridgePINVOKE.GameImpl_isMultiplayer(swigCPtr);
    return ret;
  }

  public override bool isBattleNet() {
    bool ret = bridgePINVOKE.GameImpl_isBattleNet(swigCPtr);
    return ret;
  }

  public override bool isPaused() {
    bool ret = bridgePINVOKE.GameImpl_isPaused(swigCPtr);
    return ret;
  }

  public override bool isReplay() {
    bool ret = bridgePINVOKE.GameImpl_isReplay(swigCPtr);
    return ret;
  }

  public override void startGame() {
    bridgePINVOKE.GameImpl_startGame(swigCPtr);
  }

  public override void pauseGame() {
    bridgePINVOKE.GameImpl_pauseGame(swigCPtr);
  }

  public override void resumeGame() {
    bridgePINVOKE.GameImpl_resumeGame(swigCPtr);
  }

  public override void leaveGame() {
    bridgePINVOKE.GameImpl_leaveGame(swigCPtr);
  }

  public override void restartGame() {
    bridgePINVOKE.GameImpl_restartGame(swigCPtr);
  }

  public override void setLocalSpeed(int speed) {
    bridgePINVOKE.GameImpl_setLocalSpeed__SWIG_0(swigCPtr, speed);
  }

  public override void setLocalSpeed() {
    bridgePINVOKE.GameImpl_setLocalSpeed__SWIG_1(swigCPtr);
  }

  public override UnitPtrSet getSelectedUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.GameImpl_getSelectedUnits(swigCPtr), false);
    return ret;
  }

  public override Player self() {
    IntPtr cPtr = bridgePINVOKE.GameImpl_self(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public override Player enemy() {
    IntPtr cPtr = bridgePINVOKE.GameImpl_enemy(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public override void setTextSize(int size) {
    bridgePINVOKE.GameImpl_setTextSize__SWIG_0(swigCPtr, size);
  }

  public override void setTextSize() {
    bridgePINVOKE.GameImpl_setTextSize__SWIG_1(swigCPtr);
  }

  public override void drawText(int ctype, int x, int y, string text) {
    bridgePINVOKE.GameImpl_drawText(swigCPtr, ctype, x, y, text);
  }

  public override void drawTextMap(int x, int y, string text) {
    bridgePINVOKE.GameImpl_drawTextMap(swigCPtr, x, y, text);
  }

  public override void drawTextMouse(int x, int y, string text) {
    bridgePINVOKE.GameImpl_drawTextMouse(swigCPtr, x, y, text);
  }

  public override void drawTextScreen(int x, int y, string text) {
    bridgePINVOKE.GameImpl_drawTextScreen(swigCPtr, x, y, text);
  }

  public override void drawBox(int ctype, int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawBox__SWIG_0(swigCPtr, ctype, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBox(int ctype, int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.GameImpl_drawBox__SWIG_1(swigCPtr, ctype, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxMap(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawBoxMap__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxMap(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.GameImpl_drawBoxMap__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxMouse(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawBoxMouse__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxMouse(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.GameImpl_drawBoxMouse__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxScreen(int left, int top, int right, int bottom, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawBoxScreen__SWIG_0(swigCPtr, left, top, right, bottom, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawBoxScreen(int left, int top, int right, int bottom, Color color) {
    bridgePINVOKE.GameImpl_drawBoxScreen__SWIG_1(swigCPtr, left, top, right, bottom, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangle(int ctype, int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawTriangle__SWIG_0(swigCPtr, ctype, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangle(int ctype, int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.GameImpl_drawTriangle__SWIG_1(swigCPtr, ctype, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleMap(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawTriangleMap__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleMap(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.GameImpl_drawTriangleMap__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleMouse(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawTriangleMouse__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleMouse(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.GameImpl_drawTriangleMouse__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleScreen(int ax, int ay, int bx, int by, int cx, int cy, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawTriangleScreen__SWIG_0(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawTriangleScreen(int ax, int ay, int bx, int by, int cx, int cy, Color color) {
    bridgePINVOKE.GameImpl_drawTriangleScreen__SWIG_1(swigCPtr, ax, ay, bx, by, cx, cy, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircle(int ctype, int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawCircle__SWIG_0(swigCPtr, ctype, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircle(int ctype, int x, int y, int radius, Color color) {
    bridgePINVOKE.GameImpl_drawCircle__SWIG_1(swigCPtr, ctype, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleMap(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawCircleMap__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleMap(int x, int y, int radius, Color color) {
    bridgePINVOKE.GameImpl_drawCircleMap__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleMouse(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawCircleMouse__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleMouse(int x, int y, int radius, Color color) {
    bridgePINVOKE.GameImpl_drawCircleMouse__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleScreen(int x, int y, int radius, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawCircleScreen__SWIG_0(swigCPtr, x, y, radius, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawCircleScreen(int x, int y, int radius, Color color) {
    bridgePINVOKE.GameImpl_drawCircleScreen__SWIG_1(swigCPtr, x, y, radius, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipse(int ctype, int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawEllipse__SWIG_0(swigCPtr, ctype, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipse(int ctype, int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.GameImpl_drawEllipse__SWIG_1(swigCPtr, ctype, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseMap(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawEllipseMap__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseMap(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.GameImpl_drawEllipseMap__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseMouse(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawEllipseMouse__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseMouse(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.GameImpl_drawEllipseMouse__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseScreen(int x, int y, int xrad, int yrad, Color color, bool isSolid) {
    bridgePINVOKE.GameImpl_drawEllipseScreen__SWIG_0(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color), isSolid);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawEllipseScreen(int x, int y, int xrad, int yrad, Color color) {
    bridgePINVOKE.GameImpl_drawEllipseScreen__SWIG_1(swigCPtr, x, y, xrad, yrad, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawDot(int ctype, int x, int y, Color color) {
    bridgePINVOKE.GameImpl_drawDot(swigCPtr, ctype, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawDotMap(int x, int y, Color color) {
    bridgePINVOKE.GameImpl_drawDotMap(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawDotMouse(int x, int y, Color color) {
    bridgePINVOKE.GameImpl_drawDotMouse(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawDotScreen(int x, int y, Color color) {
    bridgePINVOKE.GameImpl_drawDotScreen(swigCPtr, x, y, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawLine(int ctype, int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.GameImpl_drawLine(swigCPtr, ctype, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawLineMap(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.GameImpl_drawLineMap(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawLineMouse(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.GameImpl_drawLineMouse(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void drawLineScreen(int x1, int y1, int x2, int y2, Color color) {
    bridgePINVOKE.GameImpl_drawLineScreen(swigCPtr, x1, y1, x2, y2, Color.getCPtr(color));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public override SWIGTYPE_p_void getScreenBuffer() {
    IntPtr cPtr = bridgePINVOKE.GameImpl_getScreenBuffer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public override int getLatencyFrames() {
    int ret = bridgePINVOKE.GameImpl_getLatencyFrames(swigCPtr);
    return ret;
  }

  public override int getLatencyTime() {
    int ret = bridgePINVOKE.GameImpl_getLatencyTime(swigCPtr);
    return ret;
  }

  public override int getRemainingLatencyFrames() {
    int ret = bridgePINVOKE.GameImpl_getRemainingLatencyFrames(swigCPtr);
    return ret;
  }

  public override int getRemainingLatencyTime() {
    int ret = bridgePINVOKE.GameImpl_getRemainingLatencyTime(swigCPtr);
    return ret;
  }

  public override int getRevision() {
    int ret = bridgePINVOKE.GameImpl_getRevision(swigCPtr);
    return ret;
  }

  public override bool isDebug() {
    bool ret = bridgePINVOKE.GameImpl_isDebug(swigCPtr);
    return ret;
  }

  public override bool isLatComEnabled() {
    bool ret = bridgePINVOKE.GameImpl_isLatComEnabled(swigCPtr);
    return ret;
  }

  public override void setLatCom(bool isEnabled) {
    bridgePINVOKE.GameImpl_setLatCom(swigCPtr, isEnabled);
  }

  public override int getReplayFrameCount() {
    int ret = bridgePINVOKE.GameImpl_getReplayFrameCount(swigCPtr);
    return ret;
  }

  public override void setGUI(bool enabled) {
    bridgePINVOKE.GameImpl_setGUI__SWIG_0(swigCPtr, enabled);
  }

  public override void setGUI() {
    bridgePINVOKE.GameImpl_setGUI__SWIG_1(swigCPtr);
  }

}

}